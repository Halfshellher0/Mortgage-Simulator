using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace House_Budget
{
    public partial class Form1 : Form
    {
        //Expense File Locations.
        static string fileRootDir = Application.StartupPath + "\\";
        static string rentExpenseFile = fileRootDir + "ExpensesRent.csv";
        static string houseExpenseFile = fileRootDir + "ExpensesHouse.csv";
        static string bothExpenseFile = fileRootDir + "ExpensesRentOrHouse.csv";

        static bool scrollbarMoving = false;
        static bool textChanging = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void SaveExpenses(string fileName, DataGridView dgv)
        {
            List<string[]> saveData = new List<string[]>();
            foreach (DataGridViewRow r in dgv.Rows)
            {
                string[] rowData = new string[r.Cells.Count];
                int cellCounter = 0;
                bool addRow = true;
                foreach (DataGridViewCell c in r.Cells)
                {
                    try
                    {
                        rowData[cellCounter] = c.Value.ToString();
                        cellCounter++;
                    }
                    catch
                    {
                        addRow = false;
                    }
                }
                if (addRow)
                {
                    saveData.Add(rowData);
                }
            }

            string saveText = "";
            bool firstRun = true;
            foreach (string[] line in saveData)
            {
                if (firstRun)
                {
                    //Don't Add a newLine on the first Row.
                    firstRun = false;
                }
                else
                {
                    saveText += Environment.NewLine;
                }
                string rowText = "";
                foreach (string cell in line)
                {
                    rowText += cell + ",";
                }
                rowText = rowText.TrimEnd(',');
                saveText += rowText;
            }

            File.WriteAllText(fileName, saveText);

        }

        private void LoadExpenses(string fileName, DataGridView dgv)
        {
            if (File.Exists(fileName))
            {
                dgv.Rows.Clear();
                string[] fileLines = File.ReadAllLines(fileName);
                bool firstRun = true;
                int rowCount = 0;
                foreach (string line in fileLines)
                {
                    dgv.Rows.Add();
                }

                foreach (string line in fileLines)
                {
                    if (firstRun)
                    {
                        firstRun = false;
                    }
                    else
                    {
                        rowCount++;
                    }

                    string[] splitter = line.Split(',');
                    int cellCounter = 0;
                    foreach (string s in splitter)
                    {
                        dgv.Rows[rowCount].Cells[cellCounter].Value = s;
                        cellCounter++;
                    }
                }
            }

        }

        private void CalculateTotalExpenses()
        {
            double totalRentExpense = 0d;
            double totalHouseExpense = 0d;
            double totalBothExpense = 0d;
            double totalMortgageExpense = 0d;
            double totalAfterMortgageExpense = 0d;
            double costOfHouse = Convert.ToDouble(tb_CostOfHouse.Text);
            double propertyTax = Convert.ToDouble(tb_PropertyTax.Text) / 100d;
            double mortgagePayment = Convert.ToDouble(tb_MonthlyMortgagePayment.Text);
            double rentalIncome = Convert.ToDouble(tb_RentalIncome.Text);

            foreach (DataGridViewRow r in dgv_ExpensesWhenRenting.Rows)
            {
                totalRentExpense += Convert.ToDouble(r.Cells[1].Value);
            }

            foreach (DataGridViewRow r in dgv_ExpensesWhenOwning.Rows)
            {
                totalHouseExpense += Convert.ToDouble(r.Cells[1].Value);
            }

            foreach (DataGridViewRow r in dgv_ExpensesRentOrOwn.Rows)
            {
                totalBothExpense += Convert.ToDouble(r.Cells[1].Value);
            }

            totalRentExpense += totalBothExpense;
            totalAfterMortgageExpense = totalHouseExpense + totalBothExpense + (costOfHouse * (propertyTax / 12d)) - rentalIncome;
            totalMortgageExpense = totalAfterMortgageExpense + mortgagePayment;

            tb_TotalRentExpense.Text = "$" + totalRentExpense.ToString("0.00");
            tb_TotalMortgageExpense.Text = "$" + totalMortgageExpense.ToString("0.00");
            tb_TotalAfterMortgageExpense.Text = "$" + totalAfterMortgageExpense.ToString("0.00");
        }

        private void SetTextboxFromScrollbar(TextBox textBox, int value, int decimals)
        {
            if (!textChanging)
            {
                scrollbarMoving = true;
                double multiplier = 0d;
                string formatString = "0";
                switch (decimals)
                {
                    case 0:
                        multiplier = 1d;
                        formatString = "0";
                        break;
                    case 1:
                        multiplier = 0.1d;
                        formatString = "0.0";
                        break;
                    case 2:
                        multiplier = 0.01d;
                        formatString = "0.00";
                        break;
                    case 3:
                        multiplier = 0.001d;
                        formatString = "0.000";
                        break;
                    case 4:
                        multiplier = 0.0001d;
                        formatString = "0.0000";
                        break;
                    case 5:
                        multiplier = 0.00001d;
                        formatString = "0.00000";
                        break;
                    case 6:
                        multiplier = 0.000001d;
                        formatString = "0.000000";
                        break;
                }

                double textValue = (double)value * multiplier;
                textBox.Text = textValue.ToString(formatString);
                scrollbarMoving = false;
            }

            ////////////////////////////////////////////////////////////////////////
            dgv_SimulationReview.Rows.Clear();
            chart_DownpaymentCompare.Series[0].Points.Clear();
            chart_DownpaymentCompare.Series[1].Points.Clear();
            double rentNetWorth = RunRentSimulation(20);


            for (int i = 10; i <= 100; i++)
            {
                RunSimulation(i, 20);
                chart_DownpaymentCompare.Series[1].Points.AddXY((double)i, rentNetWorth);
            }



            double maxNetWorth = 0d;
            double minNetWorth = 9999999999d;
            foreach (DataPoint p in chart_DownpaymentCompare.Series[0].Points)
            {
                if (p.YValues[0] > maxNetWorth)
                {
                    maxNetWorth = p.YValues[0];
                }

                if (p.YValues[0] < minNetWorth)
                {
                    minNetWorth = p.YValues[0];
                }
            }

            maxNetWorth = Math.Floor(Math.Max(maxNetWorth, rentNetWorth) * 1.005);
            minNetWorth = Math.Floor(Math.Min(minNetWorth, rentNetWorth) * 0.995);

            chart_DownpaymentCompare.ChartAreas[0].AxisY.Minimum = minNetWorth;
            chart_DownpaymentCompare.ChartAreas[0].AxisY.Maximum = maxNetWorth;
            ////////////////////////////////////////////////////////////////////////

        }

        private void SetScrollbarFromTextbox(HScrollBar scrollbar, double value, int decimals)
        {
            if (!scrollbarMoving)
            {
                textChanging = true;
                double multiplier = 0d;
                switch (decimals)
                {
                    case 0:
                        multiplier = 1d;
                        break;
                    case 1:
                        multiplier = 10d;
                        break;
                    case 2:
                        multiplier = 100d;
                        break;
                    case 3:
                        multiplier = 1000d;
                        break;
                    case 4:
                        multiplier = 10000d;
                        break;
                    case 5:
                        multiplier = 100000d;
                        break;
                    case 6:
                        multiplier = 1000000d;
                        break;
                }
                int scrollBarValue = (int)(value * multiplier);
                if (scrollBarValue >= scrollbar.Maximum)
                {
                    scrollBarValue = scrollbar.Maximum;
                }
                else if (scrollBarValue <= scrollbar.Minimum)
                {
                    scrollBarValue = scrollbar.Minimum;
                }
                scrollbar.Value = scrollBarValue;
                textChanging = false;
            }
        }

        private void RunSimulation(int percentDownpayment, int simulationDurationYears)
        {
            //Constants
            const double oneOver12 = 1d / 12d;

            //Input Variables
            double totalRentExpense = 0d;
            double totalHouseExpense = 0d;
            double totalBothExpense = 0d;
            double initialCostOfHouse = Convert.ToDouble(tb_CostOfHouse.Text);
            double propertyTaxRate = 1d + (Convert.ToDouble(tb_PropertyTax.Text) / 100d);
            double monthlyPropertyTaxRate = Math.Pow(propertyTaxRate, oneOver12);
            double propertyValueIncreaseRate = 1d + (Convert.ToDouble(tb_PropertyValueIncrease.Text) / 100d);
            double monthlyPropertyValueIncreaseRate = Math.Pow(propertyValueIncreaseRate, oneOver12);
            double mortgageRate = 1d + (Convert.ToDouble(tb_MortgageRate.Text) / 100d);
            double monthlyMortgageRate = Math.Pow(mortgageRate, oneOver12);
            double mortgagePayment = Convert.ToDouble(tb_MonthlyMortgagePayment.Text);
            double initialSaving = Convert.ToDouble(tb_InitialSavings.Text);
            double purchaseCost = Convert.ToDouble(tb_OneTimePurchaseCost.Text);
            double rentalIncome = Convert.ToDouble(tb_RentalIncome.Text);
            double initialNetWorth = Convert.ToDouble(tb_CurrentNetWorth.Text);
            double annualIncome = Convert.ToDouble(tb_Income.Text);
            double jobIncome = annualIncome / 12d;
            double savingsInterest = 1d + (Convert.ToDouble(tb_AnnualSavingsInterest.Text) / 100d);
            double monthlySavingsInterest = Math.Pow(savingsInterest, oneOver12);
            foreach (DataGridViewRow row in dgv_ExpensesWhenRenting.Rows)
            {
                totalRentExpense += Convert.ToDouble(row.Cells[1].Value);
            }
            foreach (DataGridViewRow row in dgv_ExpensesWhenOwning.Rows)
            {
                totalHouseExpense += Convert.ToDouble(row.Cells[1].Value);
            }
            foreach (DataGridViewRow row in dgv_ExpensesRentOrOwn.Rows)
            {
                totalBothExpense += Convert.ToDouble(row.Cells[1].Value);
            }

            //Simulation Variables
            int simMonths = simulationDurationYears * 12;
            double goalPurchaseDollars = 0;
            double currentSavings = initialNetWorth;
            double currentCostOfHouse = initialCostOfHouse;
            double currentMortgageAmount = 0;
            bool currentlyOwning = false;
            bool mortgagePaid = false;
            DateTime today = DateTime.Now;
            DateTime simDate = new DateTime(today.Year, today.Month, 1);

            //Output Variables
            double downPaymentAmount = 0d;
            double costOfHouseAtPurchase = 0d;
            DateTime dateOfHousePurchase = today;
            DateTime dateOfMortgageEnd = new DateTime(3999, 1, 1);
            double netWorthAtEnd = 0d;

            //Simulation Loop
            for (int month = 1; month < simMonths; month++)
            {
                if (!currentlyOwning)
                {
                    //Determine Whether to Buy
                    goalPurchaseDollars = (((double)percentDownpayment / 100d) * currentCostOfHouse) + initialSaving + purchaseCost;
                    if (currentSavings > goalPurchaseDollars)
                    {
                        currentlyOwning = true;
                        costOfHouseAtPurchase = currentCostOfHouse;
                        dateOfHousePurchase = simDate;
                        double amountPaid = (((double)percentDownpayment / 100d) * currentCostOfHouse);
                        downPaymentAmount = amountPaid;
                        currentSavings -= amountPaid;
                        currentSavings -= purchaseCost;
                        currentMortgageAmount = currentCostOfHouse - amountPaid;
                    }
                }
            

                //Increase Date by one Month
                simDate = simDate.AddMonths(1);

                //Update Variables
                currentCostOfHouse = currentCostOfHouse * monthlyPropertyValueIncreaseRate;

                double monthlyExpense = 0d;
                double monthlyIncome = 0d;
                double savingInterest = currentSavings * (monthlySavingsInterest - 1d);

                if (!currentlyOwning)
                {
                    //Renting
                    //Calculate Monthly Expenses
                    monthlyExpense += totalRentExpense;
                    monthlyExpense += totalBothExpense;

                    //Calculate Monthly Income
                    monthlyIncome += jobIncome;
                    monthlyIncome += savingInterest;
                }
                else if (currentlyOwning && !mortgagePaid)
                {
                    //Owning With Mortgage
                    //Mortgage Payment
                    double interestToPay = (monthlyMortgageRate - 1d) * currentMortgageAmount;
                    double monthlyMortgagePayment = mortgagePayment;
                    if (mortgagePayment >= currentMortgageAmount + interestToPay)
                    {
                        monthlyMortgagePayment = currentMortgageAmount + interestToPay;
                        currentMortgageAmount = 0d;
                        dateOfMortgageEnd = simDate;
                        mortgagePaid = true;
                    }
                    else
                    {
                        currentMortgageAmount -= (mortgagePayment - interestToPay);
                    }
                    
                    //Calculate Monthly Expenses
                    double monthlyPropertyTax = currentCostOfHouse * (monthlyPropertyTaxRate - 1d);
                    monthlyExpense += totalHouseExpense;
                    monthlyExpense += totalBothExpense;
                    monthlyExpense += monthlyPropertyTax;
                    monthlyExpense += monthlyMortgagePayment;

                    //Calculate Monthly Income
                    monthlyIncome += jobIncome;
                    monthlyIncome += rentalIncome;
                    monthlyIncome += savingInterest;


                }
                else
                {
                    //Owning Without Mortgage
                    //Calculate Monthly Expenses
                    double monthlyPropertyTax = currentCostOfHouse * (monthlyPropertyTaxRate - 1d);
                    monthlyExpense += totalHouseExpense;
                    monthlyExpense += totalBothExpense;
                    monthlyExpense += monthlyPropertyTax;

                    //Calculate Monthly Income
                    monthlyIncome += jobIncome;
                    monthlyIncome += rentalIncome;
                    monthlyIncome += savingInterest;
                }


                //Update Variables
                currentSavings += (monthlyIncome - monthlyExpense);

            }

            if (!currentlyOwning)
            {
                netWorthAtEnd = currentSavings;
            }
            else if (currentlyOwning && !mortgagePaid)
            {
                netWorthAtEnd = currentSavings + currentCostOfHouse - currentMortgageAmount;
            }
            else
            {
                netWorthAtEnd = currentSavings + currentCostOfHouse;
            }



            //Add to Grid
            DataGridViewRow r = new DataGridViewRow();
            DataGridViewCell c1 = new DataGridViewTextBoxCell();
            c1.Value = percentDownpayment.ToString() + "%";
            DataGridViewCell c2 = new DataGridViewTextBoxCell();
            c2.Value = "$" + downPaymentAmount.ToString("0.00");
            DataGridViewCell c3 = new DataGridViewTextBoxCell();
            c3.Value = "$" + costOfHouseAtPurchase.ToString("0.00");
            DataGridViewCell c4 = new DataGridViewTextBoxCell();
            c4.Value = dateOfHousePurchase.ToShortDateString();
            DataGridViewCell c5 = new DataGridViewTextBoxCell();
            c5.Value = dateOfMortgageEnd.ToShortDateString();
            if (c5.Value.ToString() == "3999-01-01")
            {
                c5.Value = "Still Under Mortgage.";
            }
            if(c3.Value.ToString() == "$0.00")
            {
                c4.Value = "House Not Purchased.";
                c5.Value = "House Not Purchased.";
            }
            DataGridViewCell c6 = new DataGridViewTextBoxCell();
            c6.Value = "$" + netWorthAtEnd.ToString("0.00");
            r.Cells.Add(c1);
            r.Cells.Add(c2);
            r.Cells.Add(c3);
            r.Cells.Add(c4);
            r.Cells.Add(c5);
            r.Cells.Add(c6);
            dgv_SimulationReview.Rows.Add(r);

            //Add To Chart
            chart_DownpaymentCompare.Series[0].Points.AddXY((double)percentDownpayment, netWorthAtEnd);
        }

        private double RunRentSimulation(int simulationDurationYears)
        {
            //Constants
            const double oneOver12 = 1d / 12d;

            //Input Variables
            double totalRentExpense = 0d;
            double totalHouseExpense = 0d;
            double totalBothExpense = 0d;
            double initialCostOfHouse = Convert.ToDouble(tb_CostOfHouse.Text);
            double propertyTaxRate = 1d + (Convert.ToDouble(tb_PropertyTax.Text) / 100d);
            double monthlyPropertyTaxRate = Math.Pow(propertyTaxRate, oneOver12);
            double propertyValueIncreaseRate = 1d + (Convert.ToDouble(tb_PropertyValueIncrease.Text) / 100d);
            double monthlyPropertyValueIncreaseRate = Math.Pow(propertyValueIncreaseRate, oneOver12);
            double mortgageRate = 1d + (Convert.ToDouble(tb_MortgageRate.Text) / 100d);
            double monthlyMortgageRate = Math.Pow(mortgageRate, oneOver12);
            double mortgagePayment = Convert.ToDouble(tb_MonthlyMortgagePayment.Text);
            double initialSaving = Convert.ToDouble(tb_InitialSavings.Text);
            double purchaseCost = Convert.ToDouble(tb_OneTimePurchaseCost.Text);
            double rentalIncome = Convert.ToDouble(tb_RentalIncome.Text);
            double initialNetWorth = Convert.ToDouble(tb_CurrentNetWorth.Text);
            double annualIncome = Convert.ToDouble(tb_Income.Text);
            double jobIncome = annualIncome / 12d;
            double savingsInterest = 1d + (Convert.ToDouble(tb_AnnualSavingsInterest.Text) / 100d);
            double monthlySavingsInterest = Math.Pow(savingsInterest, oneOver12);
            foreach (DataGridViewRow row in dgv_ExpensesWhenRenting.Rows)
            {
                totalRentExpense += Convert.ToDouble(row.Cells[1].Value);
            }
            foreach (DataGridViewRow row in dgv_ExpensesWhenOwning.Rows)
            {
                totalHouseExpense += Convert.ToDouble(row.Cells[1].Value);
            }
            foreach (DataGridViewRow row in dgv_ExpensesRentOrOwn.Rows)
            {
                totalBothExpense += Convert.ToDouble(row.Cells[1].Value);
            }

            //Simulation Variables
            int simMonths = simulationDurationYears * 12;
            double currentSavings = initialNetWorth;
            DateTime today = DateTime.Now;
            DateTime simDate = new DateTime(today.Year, today.Month, 1);

            //Output Variables
            double netWorthAtEnd = 0d;
                       
            //Simulation Loop
            for (int month = 1; month < simMonths; month++)
            {
                //Increase Date by one Month
                simDate = simDate.AddMonths(1);

                double monthlyExpense = 0d;
                double monthlyIncome = 0d;
                double savingInterest = currentSavings * (monthlySavingsInterest - 1d);

                //Renting
                //Calculate Monthly Expenses
                monthlyExpense += totalRentExpense;
                monthlyExpense += totalBothExpense;

                //Calculate Monthly Income
                monthlyIncome += jobIncome;
                monthlyIncome += savingInterest;
                
                //Update Variables
                currentSavings += (monthlyIncome - monthlyExpense);

            }
            netWorthAtEnd = currentSavings;
            return netWorthAtEnd;
        }
        private void Bt_SaveExpenses_Click(object sender, EventArgs e)
        {
            SaveExpenses(rentExpenseFile, dgv_ExpensesWhenRenting);
            SaveExpenses(houseExpenseFile, dgv_ExpensesWhenOwning);
            SaveExpenses(bothExpenseFile, dgv_ExpensesRentOrOwn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadExpenses(rentExpenseFile, dgv_ExpensesWhenRenting);
            LoadExpenses(houseExpenseFile, dgv_ExpensesWhenOwning);
            LoadExpenses(bothExpenseFile, dgv_ExpensesRentOrOwn);
            CalculateTotalExpenses();
        }

        private void Tb_CostOfHouse_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(tb_CostOfHouse.Text);
                SetScrollbarFromTextbox(hs_CostOfHouse, value, 0);
            }
            catch
            {

            }            
        }

        private void Hs_CostOfHouse_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_CostOfHouse, hs_CostOfHouse.Value, 0);
        }

        private void Tb_PropertyTax_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalExpenses();
            try
            {
                double value = Convert.ToDouble(tb_PropertyTax.Text);
                SetScrollbarFromTextbox(hs_PropertyTax, value, 5);
            }
            catch
            {

            }
        }

        private void Hs_PropertyTax_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_PropertyTax, hs_PropertyTax.Value, 5);
        }

        private void Tb_PropertyValueIncrease_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_PropertyValueIncrease.Text);
                SetScrollbarFromTextbox(hs_PropertyValueIncrease, value, 4);
            }
            catch
            {

            }
        }

        private void Hs_PropertyValueIncrease_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_PropertyValueIncrease, hs_PropertyValueIncrease.Value, 4);
        }

        private void Tb_MortgageRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_MortgageRate.Text);
                SetScrollbarFromTextbox(hs_MortgageRate, value, 1);
            }
            catch
            {

            }
        }

        private void Hs_MortgageRate_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_MortgageRate, hs_MortgageRate.Value, 1);
        }

        private void Tb_MonthlyMortgagePayment_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalExpenses();
            try
            {
                double value = Convert.ToDouble(tb_MonthlyMortgagePayment.Text);
                SetScrollbarFromTextbox(hs_MonthlyMortgagePayment, value, 0);
            }
            catch
            {

            }
        }

        private void Hs_MonthlyMortgagePayment_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_MonthlyMortgagePayment, hs_MonthlyMortgagePayment.Value, 0);
        }

        private void Tb_InitialSavings_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_InitialSavings.Text);
                SetScrollbarFromTextbox(hs_InitialSavings, value, 0);
            }
            catch
            {

            }
        }

        private void Hs_InitialSavings_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_InitialSavings, hs_InitialSavings.Value, 0);
        }

        private void Tb_OneTimePurchaseCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_OneTimePurchaseCost.Text);
                SetScrollbarFromTextbox(hs_OneTimePurchaseCost, value, 0);
            }
            catch
            {

            }
        }

        private void Hs_OneTimePurchaseCost_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_OneTimePurchaseCost, hs_OneTimePurchaseCost.Value, 0);
        }

        private void Tb_CurrentNetWorth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_CurrentNetWorth.Text);
                SetScrollbarFromTextbox(hs_CurrentNetWorth, value, 0);
            }
            catch
            {

            }
        }

        private void Hs_CurrentNetWorth_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_CurrentNetWorth, hs_CurrentNetWorth.Value, 0);
        }

        private void Tb_Income_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_Income.Text);
                SetScrollbarFromTextbox(hs_Income, value, 0);
            }
            catch
            {

            }
        }

        private void Hs_Income_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_Income, hs_Income.Value, 0);
        }

        private void Tb_AnnualSavingsInterest_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(tb_AnnualSavingsInterest.Text);
                SetScrollbarFromTextbox(hs_AnnualSavingsInterest, value, 4);
            }
            catch
            {

            }
        }

        private void Hs_AnnualSavingsInterest_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_AnnualSavingsInterest, hs_AnnualSavingsInterest.Value, 4);
        }

        private void Tb_RentalIncome_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalExpenses();
            try
            {
                double value = Convert.ToDouble(tb_RentalIncome.Text);
                SetScrollbarFromTextbox(hs_RentalIncome, value, 0);
            }
            catch
            {

            }
        }

        private void Hs_RentalIncome_Scroll(object sender, ScrollEventArgs e)
        {
            SetTextboxFromScrollbar(tb_RentalIncome, hs_RentalIncome.Value, 0);
        }

        private void Bt_RunSimulation_Click(object sender, EventArgs e)
        {
            dgv_SimulationReview.Rows.Clear();
            chart_DownpaymentCompare.Series[0].Points.Clear();
            chart_DownpaymentCompare.Series[1].Points.Clear();
            double rentNetWorth = RunRentSimulation(20);


            for (int i = 10; i <= 100; i++)
            {
                RunSimulation(i, 20);
                chart_DownpaymentCompare.Series[1].Points.AddXY((double)i, rentNetWorth);
            }

            

            double maxNetWorth = 0d;
            double minNetWorth = 9999999999d;
            foreach (DataPoint p in chart_DownpaymentCompare.Series[0].Points)
            {
                if (p.YValues[0] > maxNetWorth)
                {
                    maxNetWorth = p.YValues[0];
                }

                if (p.YValues[0] < minNetWorth)
                {
                    minNetWorth = p.YValues[0];
                }
            }

            maxNetWorth = Math.Floor(Math.Max(maxNetWorth, rentNetWorth) * 1.005);
            minNetWorth = Math.Floor(Math.Min(minNetWorth, rentNetWorth) * 0.995);

            chart_DownpaymentCompare.ChartAreas[0].AxisY.Minimum = minNetWorth;
            chart_DownpaymentCompare.ChartAreas[0].AxisY.Maximum = maxNetWorth;

        }

        private void Chart_DownpaymentCompare_Click(object sender, EventArgs e)
        {

        }
    }
}
