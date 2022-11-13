using System;

class Calculatormode
{
    char stratagy = '+';
    int fitst;
    int second;
    ICalculation Calculat { get; set; } 

    public void ChangeStrategy(char @operator)
    {
        if (@operator == '+')
        {
            stratagy = @operator;
        }
        if (@operator == '-')
        {
            stratagy = @operator;
        }
        if (@operator == '*')
        {
            stratagy = @operator;
        }
        if (@operator == '/')
        {
            stratagy = @operator;
        }
    }

    public int PerformCalculation(int firstOperand, int secondOperand)
    {
        if (stratagy == '+')
        {
            Calculat = new Addition();
        }
        if (stratagy == '-')
        {
            Calculat = new Substraction();
        }
        if (stratagy == '*')
        {
            Calculat = new Multiplication();
        }
        if (stratagy == '/')
        {
            Calculat = new Division();
        }

        return Calculat.Calculation(firstOperand, secondOperand);

    }

}