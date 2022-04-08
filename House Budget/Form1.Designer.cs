namespace House_Budget
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hs_RentalIncome = new System.Windows.Forms.HScrollBar();
            this.tb_RentalIncome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.bt_RunSimulation = new System.Windows.Forms.Button();
            this.hs_AnnualSavingsInterest = new System.Windows.Forms.HScrollBar();
            this.hs_Income = new System.Windows.Forms.HScrollBar();
            this.hs_CurrentNetWorth = new System.Windows.Forms.HScrollBar();
            this.hs_OneTimePurchaseCost = new System.Windows.Forms.HScrollBar();
            this.hs_InitialSavings = new System.Windows.Forms.HScrollBar();
            this.hs_MonthlyMortgagePayment = new System.Windows.Forms.HScrollBar();
            this.hs_MortgageRate = new System.Windows.Forms.HScrollBar();
            this.hs_PropertyValueIncrease = new System.Windows.Forms.HScrollBar();
            this.hs_PropertyTax = new System.Windows.Forms.HScrollBar();
            this.hs_CostOfHouse = new System.Windows.Forms.HScrollBar();
            this.tb_OneTimePurchaseCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_InitialSavings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_MonthlyMortgagePayment = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_AnnualSavingsInterest = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_MortgageRate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_PropertyValueIncrease = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_PropertyTax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CostOfHouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Income = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CurrentNetWorth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ExpensesWhenOwning = new System.Windows.Forms.DataGridView();
            this.ExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.dgv_ExpensesRentOrOwn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_ExpensesWhenRenting = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_TotalRentExpense = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_SaveExpenses = new System.Windows.Forms.Button();
            this.tb_TotalAfterMortgageExpense = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_TotalMortgageExpense = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SimulationResults = new System.Windows.Forms.GroupBox();
            this.chart_DownpaymentCompare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_SimulationReview = new System.Windows.Forms.DataGridView();
            this.PercentDownPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatePaidOff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetWorth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpensesWhenOwning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpensesRentOrOwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpensesWhenRenting)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SimulationResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_DownpaymentCompare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SimulationReview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.hs_RentalIncome);
            this.groupBox1.Controls.Add(this.tb_RentalIncome);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.bt_RunSimulation);
            this.groupBox1.Controls.Add(this.hs_AnnualSavingsInterest);
            this.groupBox1.Controls.Add(this.hs_Income);
            this.groupBox1.Controls.Add(this.hs_CurrentNetWorth);
            this.groupBox1.Controls.Add(this.hs_OneTimePurchaseCost);
            this.groupBox1.Controls.Add(this.hs_InitialSavings);
            this.groupBox1.Controls.Add(this.hs_MonthlyMortgagePayment);
            this.groupBox1.Controls.Add(this.hs_MortgageRate);
            this.groupBox1.Controls.Add(this.hs_PropertyValueIncrease);
            this.groupBox1.Controls.Add(this.hs_PropertyTax);
            this.groupBox1.Controls.Add(this.hs_CostOfHouse);
            this.groupBox1.Controls.Add(this.tb_OneTimePurchaseCost);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tb_InitialSavings);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.tb_MonthlyMortgagePayment);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tb_AnnualSavingsInterest);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tb_MortgageRate);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tb_PropertyValueIncrease);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_PropertyTax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_CostOfHouse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Income);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_CurrentNetWorth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(438, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 887);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variables";
            // 
            // hs_RentalIncome
            // 
            this.hs_RentalIncome.Location = new System.Drawing.Point(14, 516);
            this.hs_RentalIncome.Maximum = 2000;
            this.hs_RentalIncome.Name = "hs_RentalIncome";
            this.hs_RentalIncome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_RentalIncome.Size = new System.Drawing.Size(289, 17);
            this.hs_RentalIncome.TabIndex = 59;
            this.hs_RentalIncome.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_RentalIncome_Scroll);
            // 
            // tb_RentalIncome
            // 
            this.tb_RentalIncome.Location = new System.Drawing.Point(202, 493);
            this.tb_RentalIncome.Name = "tb_RentalIncome";
            this.tb_RentalIncome.Size = new System.Drawing.Size(101, 20);
            this.tb_RentalIncome.TabIndex = 58;
            this.tb_RentalIncome.Text = "0";
            this.tb_RentalIncome.TextChanged += new System.EventHandler(this.Tb_RentalIncome_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(63, 496);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 13);
            this.label19.TabIndex = 57;
            this.label19.Text = "Rental Income from House";
            // 
            // bt_RunSimulation
            // 
            this.bt_RunSimulation.Location = new System.Drawing.Point(19, 768);
            this.bt_RunSimulation.Name = "bt_RunSimulation";
            this.bt_RunSimulation.Size = new System.Drawing.Size(102, 23);
            this.bt_RunSimulation.TabIndex = 46;
            this.bt_RunSimulation.Text = "Run Simulation";
            this.bt_RunSimulation.UseVisualStyleBackColor = true;
            this.bt_RunSimulation.Click += new System.EventHandler(this.Bt_RunSimulation_Click);
            // 
            // hs_AnnualSavingsInterest
            // 
            this.hs_AnnualSavingsInterest.Location = new System.Drawing.Point(14, 722);
            this.hs_AnnualSavingsInterest.Maximum = 100000;
            this.hs_AnnualSavingsInterest.Name = "hs_AnnualSavingsInterest";
            this.hs_AnnualSavingsInterest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_AnnualSavingsInterest.Size = new System.Drawing.Size(289, 17);
            this.hs_AnnualSavingsInterest.TabIndex = 56;
            this.hs_AnnualSavingsInterest.Value = 20000;
            this.hs_AnnualSavingsInterest.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_AnnualSavingsInterest_Scroll);
            // 
            // hs_Income
            // 
            this.hs_Income.Location = new System.Drawing.Point(14, 659);
            this.hs_Income.Maximum = 200000;
            this.hs_Income.Name = "hs_Income";
            this.hs_Income.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_Income.Size = new System.Drawing.Size(289, 17);
            this.hs_Income.TabIndex = 55;
            this.hs_Income.Value = 79693;
            this.hs_Income.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_Income_Scroll);
            // 
            // hs_CurrentNetWorth
            // 
            this.hs_CurrentNetWorth.Location = new System.Drawing.Point(14, 596);
            this.hs_CurrentNetWorth.Maximum = 300000;
            this.hs_CurrentNetWorth.Name = "hs_CurrentNetWorth";
            this.hs_CurrentNetWorth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_CurrentNetWorth.Size = new System.Drawing.Size(289, 17);
            this.hs_CurrentNetWorth.TabIndex = 54;
            this.hs_CurrentNetWorth.Value = 116804;
            this.hs_CurrentNetWorth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_CurrentNetWorth_Scroll);
            // 
            // hs_OneTimePurchaseCost
            // 
            this.hs_OneTimePurchaseCost.Location = new System.Drawing.Point(14, 456);
            this.hs_OneTimePurchaseCost.Maximum = 10000;
            this.hs_OneTimePurchaseCost.Name = "hs_OneTimePurchaseCost";
            this.hs_OneTimePurchaseCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_OneTimePurchaseCost.Size = new System.Drawing.Size(289, 17);
            this.hs_OneTimePurchaseCost.TabIndex = 53;
            this.hs_OneTimePurchaseCost.Value = 2000;
            this.hs_OneTimePurchaseCost.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_OneTimePurchaseCost_Scroll);
            // 
            // hs_InitialSavings
            // 
            this.hs_InitialSavings.Location = new System.Drawing.Point(14, 385);
            this.hs_InitialSavings.Maximum = 100000;
            this.hs_InitialSavings.Name = "hs_InitialSavings";
            this.hs_InitialSavings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_InitialSavings.Size = new System.Drawing.Size(289, 17);
            this.hs_InitialSavings.TabIndex = 52;
            this.hs_InitialSavings.Value = 30000;
            this.hs_InitialSavings.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_InitialSavings_Scroll);
            // 
            // hs_MonthlyMortgagePayment
            // 
            this.hs_MonthlyMortgagePayment.Location = new System.Drawing.Point(14, 325);
            this.hs_MonthlyMortgagePayment.Maximum = 5000;
            this.hs_MonthlyMortgagePayment.Name = "hs_MonthlyMortgagePayment";
            this.hs_MonthlyMortgagePayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_MonthlyMortgagePayment.Size = new System.Drawing.Size(289, 17);
            this.hs_MonthlyMortgagePayment.TabIndex = 51;
            this.hs_MonthlyMortgagePayment.Value = 2000;
            this.hs_MonthlyMortgagePayment.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_MonthlyMortgagePayment_Scroll);
            // 
            // hs_MortgageRate
            // 
            this.hs_MortgageRate.Location = new System.Drawing.Point(14, 259);
            this.hs_MortgageRate.Maximum = 150;
            this.hs_MortgageRate.Name = "hs_MortgageRate";
            this.hs_MortgageRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_MortgageRate.Size = new System.Drawing.Size(289, 17);
            this.hs_MortgageRate.TabIndex = 50;
            this.hs_MortgageRate.Value = 35;
            this.hs_MortgageRate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_MortgageRate_Scroll);
            // 
            // hs_PropertyValueIncrease
            // 
            this.hs_PropertyValueIncrease.Location = new System.Drawing.Point(14, 194);
            this.hs_PropertyValueIncrease.Maximum = 100000;
            this.hs_PropertyValueIncrease.Name = "hs_PropertyValueIncrease";
            this.hs_PropertyValueIncrease.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_PropertyValueIncrease.Size = new System.Drawing.Size(289, 17);
            this.hs_PropertyValueIncrease.TabIndex = 49;
            this.hs_PropertyValueIncrease.Value = 23000;
            this.hs_PropertyValueIncrease.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_PropertyValueIncrease_Scroll);
            // 
            // hs_PropertyTax
            // 
            this.hs_PropertyTax.Location = new System.Drawing.Point(14, 126);
            this.hs_PropertyTax.Maximum = 200000;
            this.hs_PropertyTax.Name = "hs_PropertyTax";
            this.hs_PropertyTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_PropertyTax.Size = new System.Drawing.Size(289, 17);
            this.hs_PropertyTax.TabIndex = 48;
            this.hs_PropertyTax.Value = 90806;
            this.hs_PropertyTax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_PropertyTax_Scroll);
            // 
            // hs_CostOfHouse
            // 
            this.hs_CostOfHouse.Location = new System.Drawing.Point(14, 66);
            this.hs_CostOfHouse.Maximum = 1000000;
            this.hs_CostOfHouse.Name = "hs_CostOfHouse";
            this.hs_CostOfHouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hs_CostOfHouse.Size = new System.Drawing.Size(289, 17);
            this.hs_CostOfHouse.TabIndex = 47;
            this.hs_CostOfHouse.Value = 300000;
            this.hs_CostOfHouse.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Hs_CostOfHouse_Scroll);
            // 
            // tb_OneTimePurchaseCost
            // 
            this.tb_OneTimePurchaseCost.Location = new System.Drawing.Point(202, 427);
            this.tb_OneTimePurchaseCost.Name = "tb_OneTimePurchaseCost";
            this.tb_OneTimePurchaseCost.Size = new System.Drawing.Size(101, 20);
            this.tb_OneTimePurchaseCost.TabIndex = 46;
            this.tb_OneTimePurchaseCost.Text = "2000";
            this.tb_OneTimePurchaseCost.TextChanged += new System.EventHandler(this.Tb_OneTimePurchaseCost_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 26);
            this.label13.TabIndex = 45;
            this.label13.Text = "One Time House Purchase Costs\r\n(Lawyer Fee, Real Estate Fee etc)";
            // 
            // tb_InitialSavings
            // 
            this.tb_InitialSavings.Location = new System.Drawing.Point(202, 362);
            this.tb_InitialSavings.Name = "tb_InitialSavings";
            this.tb_InitialSavings.Size = new System.Drawing.Size(101, 20);
            this.tb_InitialSavings.TabIndex = 44;
            this.tb_InitialSavings.Text = "30000";
            this.tb_InitialSavings.TextChanged += new System.EventHandler(this.Tb_InitialSavings_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Amount to Save After Buying House ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(51, 549);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 20);
            this.label15.TabIndex = 42;
            this.label15.Text = "Wealth Variables";
            // 
            // tb_MonthlyMortgagePayment
            // 
            this.tb_MonthlyMortgagePayment.Location = new System.Drawing.Point(202, 302);
            this.tb_MonthlyMortgagePayment.Name = "tb_MonthlyMortgagePayment";
            this.tb_MonthlyMortgagePayment.Size = new System.Drawing.Size(101, 20);
            this.tb_MonthlyMortgagePayment.TabIndex = 32;
            this.tb_MonthlyMortgagePayment.Text = "2000";
            this.tb_MonthlyMortgagePayment.TextChanged += new System.EventHandler(this.Tb_MonthlyMortgagePayment_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(60, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Monthly Mortgage Payment";
            // 
            // tb_AnnualSavingsInterest
            // 
            this.tb_AnnualSavingsInterest.Location = new System.Drawing.Point(202, 693);
            this.tb_AnnualSavingsInterest.Name = "tb_AnnualSavingsInterest";
            this.tb_AnnualSavingsInterest.Size = new System.Drawing.Size(101, 20);
            this.tb_AnnualSavingsInterest.TabIndex = 30;
            this.tb_AnnualSavingsInterest.Text = "2";
            this.tb_AnnualSavingsInterest.TextChanged += new System.EventHandler(this.Tb_AnnualSavingsInterest_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 696);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(141, 26);
            this.label16.TabIndex = 29;
            this.label16.Text = "Expected Amount of Interest\r\nearned on Savings (%)";
            // 
            // tb_MortgageRate
            // 
            this.tb_MortgageRate.Location = new System.Drawing.Point(202, 236);
            this.tb_MortgageRate.Name = "tb_MortgageRate";
            this.tb_MortgageRate.Size = new System.Drawing.Size(101, 20);
            this.tb_MortgageRate.TabIndex = 26;
            this.tb_MortgageRate.Text = "3.5";
            this.tb_MortgageRate.TextChanged += new System.EventHandler(this.Tb_MortgageRate_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 239);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Expected Annual Mortgage Rate (%)";
            // 
            // tb_PropertyValueIncrease
            // 
            this.tb_PropertyValueIncrease.Location = new System.Drawing.Point(202, 165);
            this.tb_PropertyValueIncrease.Name = "tb_PropertyValueIncrease";
            this.tb_PropertyValueIncrease.Size = new System.Drawing.Size(101, 20);
            this.tb_PropertyValueIncrease.TabIndex = 19;
            this.tb_PropertyValueIncrease.Text = "2.3";
            this.tb_PropertyValueIncrease.TextChanged += new System.EventHandler(this.Tb_PropertyValueIncrease_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "Expected Annual Property\r\nValue Increase (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "House Variables";
            // 
            // tb_PropertyTax
            // 
            this.tb_PropertyTax.Location = new System.Drawing.Point(202, 103);
            this.tb_PropertyTax.Name = "tb_PropertyTax";
            this.tb_PropertyTax.Size = new System.Drawing.Size(101, 20);
            this.tb_PropertyTax.TabIndex = 8;
            this.tb_PropertyTax.Text = "0.90806";
            this.tb_PropertyTax.TextChanged += new System.EventHandler(this.Tb_PropertyTax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Property Tax Annual (%)";
            // 
            // tb_CostOfHouse
            // 
            this.tb_CostOfHouse.Location = new System.Drawing.Point(202, 43);
            this.tb_CostOfHouse.Name = "tb_CostOfHouse";
            this.tb_CostOfHouse.Size = new System.Drawing.Size(101, 20);
            this.tb_CostOfHouse.TabIndex = 6;
            this.tb_CostOfHouse.Text = "300000";
            this.tb_CostOfHouse.TextChanged += new System.EventHandler(this.Tb_CostOfHouse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Cost of House";
            // 
            // tb_Income
            // 
            this.tb_Income.Location = new System.Drawing.Point(202, 636);
            this.tb_Income.Name = "tb_Income";
            this.tb_Income.Size = new System.Drawing.Size(101, 20);
            this.tb_Income.TabIndex = 4;
            this.tb_Income.Text = "79693";
            this.tb_Income.TextChanged += new System.EventHandler(this.Tb_Income_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expected Annual Take Home Income";
            // 
            // tb_CurrentNetWorth
            // 
            this.tb_CurrentNetWorth.Location = new System.Drawing.Point(202, 573);
            this.tb_CurrentNetWorth.Name = "tb_CurrentNetWorth";
            this.tb_CurrentNetWorth.Size = new System.Drawing.Size(101, 20);
            this.tb_CurrentNetWorth.TabIndex = 2;
            this.tb_CurrentNetWorth.Text = "116804";
            this.tb_CurrentNetWorth.TextChanged += new System.EventHandler(this.Tb_CurrentNetWorth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Net Worth";
            // 
            // dgv_ExpensesWhenOwning
            // 
            this.dgv_ExpensesWhenOwning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExpensesWhenOwning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseName,
            this.MonthlyCost});
            this.dgv_ExpensesWhenOwning.Location = new System.Drawing.Point(9, 229);
            this.dgv_ExpensesWhenOwning.Name = "dgv_ExpensesWhenOwning";
            this.dgv_ExpensesWhenOwning.Size = new System.Drawing.Size(399, 211);
            this.dgv_ExpensesWhenOwning.TabIndex = 33;
            // 
            // ExpenseName
            // 
            this.ExpenseName.HeaderText = "Expense";
            this.ExpenseName.Name = "ExpenseName";
            this.ExpenseName.Width = 200;
            // 
            // MonthlyCost
            // 
            this.MonthlyCost.HeaderText = "Monthly Cost ($)";
            this.MonthlyCost.Name = "MonthlyCost";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 213);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(352, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Expenses When Owning (Do not Include Mortgage or Property Tax Here)";
            // 
            // dgv_ExpensesRentOrOwn
            // 
            this.dgv_ExpensesRentOrOwn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExpensesRentOrOwn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_ExpensesRentOrOwn.Location = new System.Drawing.Point(10, 459);
            this.dgv_ExpensesRentOrOwn.Name = "dgv_ExpensesRentOrOwn";
            this.dgv_ExpensesRentOrOwn.Size = new System.Drawing.Size(399, 307);
            this.dgv_ExpensesRentOrOwn.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Expense";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Monthly Cost ($)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Global Monthly Expenses (Apply Whether Renting or Owning)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Expenses When Renting";
            // 
            // dgv_ExpensesWhenRenting
            // 
            this.dgv_ExpensesWhenRenting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExpensesWhenRenting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_ExpensesWhenRenting.Location = new System.Drawing.Point(9, 32);
            this.dgv_ExpensesWhenRenting.Name = "dgv_ExpensesWhenRenting";
            this.dgv_ExpensesWhenRenting.Size = new System.Drawing.Size(399, 165);
            this.dgv_ExpensesWhenRenting.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Expense";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Monthly Cost ($)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tb_TotalRentExpense
            // 
            this.tb_TotalRentExpense.Location = new System.Drawing.Point(307, 775);
            this.tb_TotalRentExpense.Name = "tb_TotalRentExpense";
            this.tb_TotalRentExpense.ReadOnly = true;
            this.tb_TotalRentExpense.Size = new System.Drawing.Size(101, 20);
            this.tb_TotalRentExpense.TabIndex = 40;
            this.tb_TotalRentExpense.Text = "$0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 778);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Total Expenses When Renting";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.bt_SaveExpenses);
            this.groupBox2.Controls.Add(this.tb_TotalAfterMortgageExpense);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_TotalMortgageExpense);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_TotalRentExpense);
            this.groupBox2.Controls.Add(this.dgv_ExpensesWhenOwning);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.dgv_ExpensesRentOrOwn);
            this.groupBox2.Controls.Add(this.dgv_ExpensesWhenRenting);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 887);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Expenses";
            // 
            // bt_SaveExpenses
            // 
            this.bt_SaveExpenses.Location = new System.Drawing.Point(9, 772);
            this.bt_SaveExpenses.Name = "bt_SaveExpenses";
            this.bt_SaveExpenses.Size = new System.Drawing.Size(102, 23);
            this.bt_SaveExpenses.TabIndex = 45;
            this.bt_SaveExpenses.Text = "Save Expenses";
            this.bt_SaveExpenses.UseVisualStyleBackColor = true;
            this.bt_SaveExpenses.Click += new System.EventHandler(this.Bt_SaveExpenses_Click);
            // 
            // tb_TotalAfterMortgageExpense
            // 
            this.tb_TotalAfterMortgageExpense.Location = new System.Drawing.Point(307, 827);
            this.tb_TotalAfterMortgageExpense.Name = "tb_TotalAfterMortgageExpense";
            this.tb_TotalAfterMortgageExpense.ReadOnly = true;
            this.tb_TotalAfterMortgageExpense.Size = new System.Drawing.Size(101, 20);
            this.tb_TotalAfterMortgageExpense.TabIndex = 44;
            this.tb_TotalAfterMortgageExpense.Text = "$0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(71, 830);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(230, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Total Expenses When Owning (After Mortgage)";
            // 
            // tb_TotalMortgageExpense
            // 
            this.tb_TotalMortgageExpense.Location = new System.Drawing.Point(307, 801);
            this.tb_TotalMortgageExpense.Name = "tb_TotalMortgageExpense";
            this.tb_TotalMortgageExpense.ReadOnly = true;
            this.tb_TotalMortgageExpense.Size = new System.Drawing.Size(101, 20);
            this.tb_TotalMortgageExpense.TabIndex = 42;
            this.tb_TotalMortgageExpense.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 804);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Total Expenses When Owning (During Mortgage)";
            // 
            // SimulationResults
            // 
            this.SimulationResults.Controls.Add(this.chart_DownpaymentCompare);
            this.SimulationResults.Controls.Add(this.dgv_SimulationReview);
            this.SimulationResults.Location = new System.Drawing.Point(776, 12);
            this.SimulationResults.Name = "SimulationResults";
            this.SimulationResults.Size = new System.Drawing.Size(981, 887);
            this.SimulationResults.TabIndex = 42;
            this.SimulationResults.TabStop = false;
            this.SimulationResults.Text = "Simulation Results";
            // 
            // chart_DownpaymentCompare
            // 
            chartArea1.AxisX.Title = "% Downpayment on House";
            chartArea1.AxisY.Title = "Net Worth After Simulation";
            chartArea1.Name = "ChartArea1";
            this.chart_DownpaymentCompare.ChartAreas.Add(chartArea1);
            this.chart_DownpaymentCompare.Location = new System.Drawing.Point(29, 325);
            this.chart_DownpaymentCompare.Name = "chart_DownpaymentCompare";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "NetWorth";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "RentOnlyLine";
            this.chart_DownpaymentCompare.Series.Add(series1);
            this.chart_DownpaymentCompare.Series.Add(series2);
            this.chart_DownpaymentCompare.Size = new System.Drawing.Size(946, 553);
            this.chart_DownpaymentCompare.TabIndex = 1;
            this.chart_DownpaymentCompare.Click += new System.EventHandler(this.Chart_DownpaymentCompare_Click);
            // 
            // dgv_SimulationReview
            // 
            this.dgv_SimulationReview.AllowUserToAddRows = false;
            this.dgv_SimulationReview.AllowUserToDeleteRows = false;
            this.dgv_SimulationReview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SimulationReview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PercentDownPayment,
            this.DownPaymentAmount,
            this.HouseCost,
            this.PurchaseDate,
            this.DatePaidOff,
            this.NetWorth});
            this.dgv_SimulationReview.Location = new System.Drawing.Point(29, 35);
            this.dgv_SimulationReview.Name = "dgv_SimulationReview";
            this.dgv_SimulationReview.ReadOnly = true;
            this.dgv_SimulationReview.Size = new System.Drawing.Size(946, 271);
            this.dgv_SimulationReview.TabIndex = 0;
            // 
            // PercentDownPayment
            // 
            this.PercentDownPayment.HeaderText = "Percent Down Payment";
            this.PercentDownPayment.Name = "PercentDownPayment";
            this.PercentDownPayment.ReadOnly = true;
            // 
            // DownPaymentAmount
            // 
            this.DownPaymentAmount.HeaderText = "Down Payment Amount";
            this.DownPaymentAmount.Name = "DownPaymentAmount";
            this.DownPaymentAmount.ReadOnly = true;
            this.DownPaymentAmount.Width = 150;
            // 
            // HouseCost
            // 
            this.HouseCost.HeaderText = "Cost of House at Time of Purchase";
            this.HouseCost.Name = "HouseCost";
            this.HouseCost.ReadOnly = true;
            this.HouseCost.Width = 150;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "Date of House Purchase";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 150;
            // 
            // DatePaidOff
            // 
            this.DatePaidOff.HeaderText = "Date of Mortgage End";
            this.DatePaidOff.Name = "DatePaidOff";
            this.DatePaidOff.ReadOnly = true;
            this.DatePaidOff.Width = 150;
            // 
            // NetWorth
            // 
            this.NetWorth.HeaderText = "Net Worth at the End of the Simulation";
            this.NetWorth.Name = "NetWorth";
            this.NetWorth.ReadOnly = true;
            this.NetWorth.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 902);
            this.Controls.Add(this.SimulationResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpensesWhenOwning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpensesRentOrOwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExpensesWhenRenting)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SimulationResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_DownpaymentCompare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SimulationReview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_CostOfHouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CurrentNetWorth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_PropertyTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_PropertyValueIncrease;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgv_ExpensesWhenOwning;
        private System.Windows.Forms.TextBox tb_MonthlyMortgagePayment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_AnnualSavingsInterest;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_MortgageRate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_ExpensesWhenRenting;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_ExpensesRentOrOwn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyCost;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_TotalMortgageExpense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_TotalRentExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_SaveExpenses;
        private System.Windows.Forms.TextBox tb_TotalAfterMortgageExpense;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_OneTimePurchaseCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_InitialSavings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.HScrollBar hs_CostOfHouse;
        private System.Windows.Forms.HScrollBar hs_PropertyTax;
        private System.Windows.Forms.HScrollBar hs_MortgageRate;
        private System.Windows.Forms.HScrollBar hs_PropertyValueIncrease;
        private System.Windows.Forms.HScrollBar hs_MonthlyMortgagePayment;
        private System.Windows.Forms.HScrollBar hs_AnnualSavingsInterest;
        private System.Windows.Forms.HScrollBar hs_Income;
        private System.Windows.Forms.HScrollBar hs_CurrentNetWorth;
        private System.Windows.Forms.HScrollBar hs_OneTimePurchaseCost;
        private System.Windows.Forms.HScrollBar hs_InitialSavings;
        private System.Windows.Forms.Button bt_RunSimulation;
        private System.Windows.Forms.GroupBox SimulationResults;
        private System.Windows.Forms.HScrollBar hs_RentalIncome;
        private System.Windows.Forms.TextBox tb_RentalIncome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgv_SimulationReview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_DownpaymentCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentDownPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatePaidOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetWorth;
    }
}

