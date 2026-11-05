namespace CalculatorsV1;

public class BMICalculator
{
    private string name = "No Name";
    private double height = 0;       private double weight = 0;   // kg (Metric) eller lb (Imperial)
    private UnitTypes unit = UnitTypes.Metric;

    public void SetName(string value)
    {
        name = value;
    }

    public void SetHeight(double value)
    {
        height = value;
    }

    public void SetWeight(double value)
    {
        weight = value;
    }

    public void SetUnit(UnitTypes value)
    {
        unit = value;
    }

    public string GetName()
    {
        return name;
    }

    public double GetBMI()
    {
        if (unit == UnitTypes.Metric)
            return weight / (height * height);

        return 703.0 * weight / (height * height);
    }

    public string GetWeightCategory()
    {
        double bmi = GetBMI();

        if (bmi < 18.5)
            return "Underweight";
        if (bmi < 25.0)
            return "Normal weight";
        if (bmi < 30.0)
            return "Overweight (Pre-obesity)";
        if (bmi < 35.0)
            return "Overweight (Obesity class I)";
        if (bmi < 40.0)
            return "Overweight (Obesity class II)";

        return "Overweight (Obesity class III)";
    }

    public string GetNormalWeightText()
    {
        double factor = 1.0;
        string unitText = "kg";

        if (unit == UnitTypes.Imperial)
        {
            factor = 703.0;
            unitText = "lb";
        }

        double lowWeight = height * height / factor * 18.50;
        double highWeight = height * height / factor * 24.9;

        return $"Normal weight: {lowWeight:N0} - {highWeight:N0} {unitText}";
    }
}