namespace CalculatorsV1;

public class LoanRepayment
{
    private double loanAmount;
    private double annualInterestRate;
    private int periodInYears;

    public void SetLoanAmount(double amount)
    {
        loanAmount = amount;
    }

    public void SetAnnualInterestRate(double rate)
    {
        annualInterestRate = rate;
    }

    public void SetPeriodInYears(int years)
    {
        periodInYears = years;
    }

    public double GetLoanAmount()
    {
        return loanAmount;
    }

    public double GetAnnualInterestRate()
    {
        return annualInterestRate;
    }

    public int GetPeriodInYears()
    {
        return periodInYears;
    }

    public int GetNumOfPayments()
    {
        return periodInYears * 12;
    }

    public double GetMonthlyRepayment()
    {
        double r = annualInterestRate / (12 * 100.0);
        int n = GetNumOfPayments();

        if (r == 0)
            return loanAmount / n;

        return loanAmount * r / (1 - Math.Pow(1 + r, -n));
    }

    public double GetTotalPayment()
    {
        return GetMonthlyRepayment() * GetNumOfPayments();
    }

    public double GetTotalInterest()
    {
        return GetTotalPayment() - loanAmount;
    }
}