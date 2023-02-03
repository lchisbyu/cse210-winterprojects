class Fraction
{
    //Private field for the numerator;

    private int numerator;

    //Private field for the denominator
    private int denominator;

    //Constructor with no parameters, initializes to 1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    //Constructor with one parameter for the numerator
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    //Constructor with two parameters, one for the number
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    //Property for the numerator 
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }

    }
    //Property for the denominator
    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; }
    }

    //Method to return the fraction string in the form
    public string GetFractionString()
    {
        return numerator + "/" + denominator;
    }

    //Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }


}