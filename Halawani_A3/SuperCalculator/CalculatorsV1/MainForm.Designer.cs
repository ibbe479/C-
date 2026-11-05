namespace CalculatorsV1;

partial class MainForm
{
    private void InitializeComponent()
    {
        // ================= LOAN REPAYMENT =================
        grpLoan.Text = "Loan Repayment Calculator";
        grpLoan.Location = new Point(10, 10);
        grpLoan.Size = new Size(540, 190);

        grpDetails.Text = "Loan Details";
        grpDetails.Location = new Point(10, 25);
        grpDetails.Size = new Size(240, 150);

        lblAmount.Text = "Amount";
        lblAmount.Location = new Point(10, 33);
        lblAmount.AutoSize = true;
        txtAmount.Location = new Point(130, 30);
        txtAmount.Size = new Size(90, 23);

        lblInterest.Text = "Annual interest (%)";
        lblInterest.Location = new Point(10, 63);
        lblInterest.AutoSize = true;
        txtInterest.Location = new Point(130, 60);
        txtInterest.Size = new Size(90, 23);

        lblPeriod.Text = "Period (years)";
        lblPeriod.Location = new Point(10, 93);
        lblPeriod.AutoSize = true;
        txtPeriod.Location = new Point(130, 90);
        txtPeriod.Size = new Size(90, 23);

        btnCalculate.Text = "Calculate Monthly";
        btnCalculate.Location = new Point(10, 118);
        btnCalculate.Size = new Size(210, 26);
        btnCalculate.Click += btnCalculate_Click;

        grpDetails.Controls.Add(lblAmount);
        grpDetails.Controls.Add(txtAmount);
        grpDetails.Controls.Add(lblInterest);
        grpDetails.Controls.Add(txtInterest);
        grpDetails.Controls.Add(lblPeriod);
        grpDetails.Controls.Add(txtPeriod);
        grpDetails.Controls.Add(btnCalculate);

        grpSummary.Text = "Repayment Summary";
        grpSummary.Location = new Point(260, 25);
        grpSummary.Size = new Size(270, 150);

        lblMonthlyText.Text = "Monthly due amount";
        lblMonthlyText.Location = new Point(10, 33);
        lblMonthlyText.AutoSize = true;
        lblMonthly.Location = new Point(160, 30);
        lblMonthly.Size = new Size(100, 23);
        lblMonthly.BorderStyle = BorderStyle.FixedSingle;
        lblMonthly.TextAlign = ContentAlignment.MiddleRight;

        lblNumText.Text = "Num of payments";
        lblNumText.Location = new Point(10, 63);
        lblNumText.AutoSize = true;
        lblNumPayments.Location = new Point(160, 60);
        lblNumPayments.Size = new Size(100, 23);
        lblNumPayments.BorderStyle = BorderStyle.FixedSingle;
        lblNumPayments.TextAlign = ContentAlignment.MiddleRight;

        lblInterestText.Text = "Total interest";
        lblInterestText.Location = new Point(10, 93);
        lblInterestText.AutoSize = true;
        lblTotalInterest.Location = new Point(160, 90);
        lblTotalInterest.Size = new Size(100, 23);
        lblTotalInterest.BorderStyle = BorderStyle.FixedSingle;
        lblTotalInterest.TextAlign = ContentAlignment.MiddleRight;

        lblTotalText.Text = "Principal + interest";
        lblTotalText.Location = new Point(10, 123);
        lblTotalText.AutoSize = true;
        lblTotalPayment.Location = new Point(160, 120);
        lblTotalPayment.Size = new Size(100, 23);
        lblTotalPayment.BorderStyle = BorderStyle.FixedSingle;
        lblTotalPayment.TextAlign = ContentAlignment.MiddleRight;

        grpSummary.Controls.Add(lblMonthlyText);
        grpSummary.Controls.Add(lblMonthly);
        grpSummary.Controls.Add(lblNumText);
        grpSummary.Controls.Add(lblNumPayments);
        grpSummary.Controls.Add(lblInterestText);
        grpSummary.Controls.Add(lblTotalInterest);
        grpSummary.Controls.Add(lblTotalText);
        grpSummary.Controls.Add(lblTotalPayment);

        grpLoan.Controls.Add(grpDetails);
        grpLoan.Controls.Add(grpSummary);

        // ================= BMI =================
        grpBmi.Text = "BMI Calculator";
        grpBmi.Location = new Point(10, 210);
        grpBmi.Size = new Size(540, 265);

        grpPersonal.Text = "Personal info";
        grpPersonal.Location = new Point(10, 25);
        grpPersonal.Size = new Size(250, 130);

        lblName.Text = "Name";
        lblName.Location = new Point(10, 33);
        lblName.AutoSize = true;
        txtName.Location = new Point(100, 30);
        txtName.Size = new Size(130, 23);

        lblHeight.Text = "Height (cm)";
        lblHeight.Location = new Point(10, 63);
        lblHeight.AutoSize = true;
        txtHeight1.Location = new Point(100, 60);
        txtHeight1.Size = new Size(60, 23);
        txtHeight2.Location = new Point(170, 60);
        txtHeight2.Size = new Size(60, 23);

        lblWeight.Text = "Weight (kg)";
        lblWeight.Location = new Point(10, 93);
        lblWeight.AutoSize = true;
        txtWeight.Location = new Point(100, 90);
        txtWeight.Size = new Size(60, 23);

        grpPersonal.Controls.Add(lblName);
        grpPersonal.Controls.Add(txtName);
        grpPersonal.Controls.Add(lblHeight);
        grpPersonal.Controls.Add(txtHeight1);
        grpPersonal.Controls.Add(txtHeight2);
        grpPersonal.Controls.Add(lblWeight);
        grpPersonal.Controls.Add(txtWeight);

        grpUnit.Text = "Unit";
        grpUnit.Location = new Point(10, 165);
        grpUnit.Size = new Size(250, 55);

        rbtMetric.Text = "Metric (kg, cm)";
        rbtMetric.Location = new Point(10, 22);
        rbtMetric.AutoSize = true;
        rbtMetric.CheckedChanged += rbtMetric_CheckedChanged;

        rbtImperial.Text = "Imperial (ft, in, lb)";
        rbtImperial.Location = new Point(115, 22);
        rbtImperial.AutoSize = true;

        grpUnit.Controls.Add(rbtMetric);
        grpUnit.Controls.Add(rbtImperial);

        grpResults.Text = "Results";
        grpResults.Location = new Point(270, 25);
        grpResults.Size = new Size(260, 195);

        lblBmiText.Text = "BMI";
        lblBmiText.Location = new Point(10, 33);
        lblBmiText.AutoSize = true;
        lblBmi.Location = new Point(150, 30);
        lblBmi.Size = new Size(100, 23);
        lblBmi.BorderStyle = BorderStyle.FixedSingle;
        lblBmi.TextAlign = ContentAlignment.MiddleRight;

        lblCategoryText.Text = "Weight category";
        lblCategoryText.Location = new Point(10, 63);
        lblCategoryText.AutoSize = true;
        lblCategory.Location = new Point(10, 85);
        lblCategory.Size = new Size(240, 23);
        lblCategory.BorderStyle = BorderStyle.FixedSingle;
        lblCategory.TextAlign = ContentAlignment.MiddleCenter;

        lblNormalBmi.Location = new Point(10, 125);
        lblNormalBmi.AutoSize = true;
        lblNormalBmi.ForeColor = Color.Green;

        lblNormalWeight.Location = new Point(10, 155);
        lblNormalWeight.AutoSize = true;
        lblNormalWeight.ForeColor = Color.Green;

        grpResults.Controls.Add(lblBmiText);
        grpResults.Controls.Add(lblBmi);
        grpResults.Controls.Add(lblCategoryText);
        grpResults.Controls.Add(lblCategory);
        grpResults.Controls.Add(lblNormalBmi);
        grpResults.Controls.Add(lblNormalWeight);

        btnCalcBmi.Text = "Calculate BMI";
        btnCalcBmi.Location = new Point(10, 228);
        btnCalcBmi.Size = new Size(520, 28);
        btnCalcBmi.Click += btnCalcBmi_Click;

        grpBmi.Controls.Add(grpPersonal);
        grpBmi.Controls.Add(grpUnit);
        grpBmi.Controls.Add(grpResults);
        grpBmi.Controls.Add(btnCalcBmi);

        // ================= FÖNSTRET =================
        ClientSize = new Size(560, 490);
        Controls.Add(grpLoan);
        Controls.Add(grpBmi);
        Name = "MainForm";
    }

    // ----- Loan Repayment -----
    private GroupBox grpLoan = new GroupBox();
    private GroupBox grpDetails = new GroupBox();
    private GroupBox grpSummary = new GroupBox();

    private Label lblAmount = new Label();
    private Label lblInterest = new Label();
    private Label lblPeriod = new Label();
    private TextBox txtAmount = new TextBox();
    private TextBox txtInterest = new TextBox();
    private TextBox txtPeriod = new TextBox();
    private Button btnCalculate = new Button();

    private Label lblMonthlyText = new Label();
    private Label lblNumText = new Label();
    private Label lblInterestText = new Label();
    private Label lblTotalText = new Label();
    private Label lblMonthly = new Label();
    private Label lblNumPayments = new Label();
    private Label lblTotalInterest = new Label();
    private Label lblTotalPayment = new Label();

    // ----- BMI -----
    private GroupBox grpBmi = new GroupBox();
    private GroupBox grpPersonal = new GroupBox();
    private GroupBox grpUnit = new GroupBox();
    private GroupBox grpResults = new GroupBox();

    private Label lblName = new Label();
    private Label lblHeight = new Label();
    private Label lblWeight = new Label();
    private TextBox txtName = new TextBox();
    private TextBox txtHeight1 = new TextBox();
    private TextBox txtHeight2 = new TextBox();
    private TextBox txtWeight = new TextBox();

    private RadioButton rbtMetric = new RadioButton();
    private RadioButton rbtImperial = new RadioButton();

    private Label lblBmiText = new Label();
    private Label lblBmi = new Label();
    private Label lblCategoryText = new Label();
    private Label lblCategory = new Label();
    private Label lblNormalBmi = new Label();
    private Label lblNormalWeight = new Label();

    private Button btnCalcBmi = new Button();
}