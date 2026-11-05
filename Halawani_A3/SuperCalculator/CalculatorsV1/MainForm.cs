namespace CalculatorsV1;

public partial class MainForm : Form
{
    private LoanRepayment loanRepayment = new LoanRepayment();
    private BMICalculator bmiCalc = new BMICalculator();

    public MainForm()
    {
        InitializeComponent();
        InitializeGUI();
    }

    private void InitializeGUI()
    {
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Calculator V1 by Ibrahim Halawani";

        lblMonthly.Text = string.Empty;
        lblNumPayments.Text = string.Empty;
        lblTotalInterest.Text = string.Empty;
        lblTotalPayment.Text = string.Empty;

        lblBmi.Text = string.Empty;
        lblCategory.Text = string.Empty;
        lblNormalBmi.Text = string.Empty;
        lblNormalWeight.Text = string.Empty;

        rbtMetric.Checked = true;
    }

    // ================= LOAN REPAYMENT =================
    private void btnCalculate_Click(object? sender, EventArgs e)
    {
        bool ok = ReadLoanRepaymentInput();
        if (ok)
            DisplayLoanRepaymentResults();
    }

    private bool ReadLoanRepaymentInput()
    {
        bool ok = ReadLoanAmount();
        ok = ok && ReadLoanPeriod();
        ok = ok && ReadAnnualInterestRate();
        return ok;
    }

    private bool ReadLoanAmount()
    {
        double value = 0;
        bool ok = double.TryParse(txtAmount.Text, out value);
        if (ok && value > 0)
        {
            loanRepayment.SetLoanAmount(value);
            return true;
        }
        MessageBox.Show("Invalid amount; value must be a number > 0!");
        return false;
    }

    private bool ReadLoanPeriod()
    {
        int value = 0;
        bool ok = int.TryParse(txtPeriod.Text, out value);
        if (ok && value > 0)
        {
            loanRepayment.SetPeriodInYears(value);
            return true;
        }
        MessageBox.Show("Invalid period; value must be an integer > 0!");
        return false;
    }

    private bool ReadAnnualInterestRate()
    {
        double value = 0;
        bool ok = double.TryParse(txtInterest.Text, out value);
        if (ok && value >= 0)
        {
            loanRepayment.SetAnnualInterestRate(value);
            return true;
        }
        MessageBox.Show("Invalid interest rate; value must be a number >= 0!");
        return false;
    }

    private void DisplayLoanRepaymentResults()
    {
        double monthly = loanRepayment.GetMonthlyRepayment();
        lblMonthly.Text = $"{monthly:N2}";
        lblNumPayments.Text = $"{loanRepayment.GetNumOfPayments()}";
        lblTotalInterest.Text = $"{loanRepayment.GetTotalInterest():N2}";
        lblTotalPayment.Text = $"{loanRepayment.GetTotalPayment():N2}";
    }

    // ================= BMI =================
    private void rbtMetric_CheckedChanged(object? sender, EventArgs e)
    {
        if (rbtMetric.Checked)
        {
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";
            txtHeight2.Text = string.Empty;
            txtHeight2.Enabled = false;
        }
        else
        {
            lblHeight.Text = "Height (ft, in)";
            lblWeight.Text = "Weight (lb)";
            txtHeight2.Enabled = true;
        }
    }

    private void btnCalcBmi_Click(object? sender, EventArgs e)
    {
        bool ok = ReadInput();
        if (ok)
            DisplayBmiResults();
    }

    private bool ReadInput()
    {
        ReadName();
        ReadUnitType();
        bool ok = ReadWeight();
        ok = ok && ReadHeight();
        return ok;
    }

    private void ReadName()
    {
        txtName.Text = txtName.Text.Trim();
        if (!string.IsNullOrEmpty(txtName.Text))
            bmiCalc.SetName(txtName.Text);
        else
            bmiCalc.SetName("Unknown");
    }

    private void ReadUnitType()
    {
        if (rbtMetric.Checked)
            bmiCalc.SetUnit(UnitTypes.Metric);
        else
            bmiCalc.SetUnit(UnitTypes.Imperial);
    }

    private bool ReadWeight()
    {
        double value = 0;
        bool ok = double.TryParse(txtWeight.Text, out value);
        if (ok && value > 0)
        {
            bmiCalc.SetWeight(value);
            return true;
        }
        MessageBox.Show("Invalid weight; value must be a number > 0!");
        return false;
    }

    private bool ReadHeight()
    {
        if (rbtMetric.Checked)
        {
            double cm = 0;
            bool ok = double.TryParse(txtHeight1.Text, out cm);
            if (ok && cm > 0)
            {
                bmiCalc.SetHeight(cm / 100.0);   // cm -> meter
                return true;
            }
            MessageBox.Show("Invalid height; value must be a number > 0 (cm)!");
            return false;
        }
        else
        {
            double feet = 0;
            double inches = 0;
            bool okFeet = double.TryParse(txtHeight1.Text, out feet);
            bool okInches = double.TryParse(txtHeight2.Text, out inches);
            if (okFeet && okInches && feet >= 0 && inches >= 0 && (feet * 12 + inches) > 0)
            {
                bmiCalc.SetHeight(feet * 12 + inches);   // fot + tum -> tum
                return true;
            }
            MessageBox.Show("Invalid height; feet and inches must be numbers >= 0!");
            return false;
        }
    }

    private void DisplayBmiResults()
    {
        grpResults.Text = $"Results for {bmiCalc.GetName()}";
        lblBmi.Text = $"{bmiCalc.GetBMI():N2}";
        lblCategory.Text = bmiCalc.GetWeightCategory();
        lblNormalBmi.Text = "Normal BMI: 18.50 - 24.9";
        lblNormalWeight.Text = bmiCalc.GetNormalWeightText();
    }
}