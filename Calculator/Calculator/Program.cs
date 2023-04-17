using System;

public class Calculator 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Lloyd Jiperson Diaz \n\n");
        var calculator = new Calculator();
        calculator.ChooseOperator();
    }
    public void ChooseOperator()
    {
        var Calculator = new Calculator();

        Console.Write("Input Operator [+, -, *, /] :  ");
        var inoperator = Console.ReadLine();
        switch (inoperator)
        {
            case "+":
                Console.Clear();
                Calculator.Addition();
                break;
            case "-":
                Console.Clear();
                Calculator.Subtraction();
                break;
            case "*":
                Console.Clear();
                Calculator.Multiplication();
                break;
            case "/":
                Console.Clear();
                Calculator.Division();
                break;

            default:
                Console.Clear();
                Console.WriteLine("Invalid Input, please input [+, -, *, /] only");
                break;      
        }
        Console.Write("\n\nDo you want to use Calculator again [y/n] ? ");
        var YorN = Console.ReadLine();
        if (YorN == "y")
        {
            Console.Clear();
            Calculator.ChooseOperator();
        }
        else
        {
            Environment.Exit(0);
        }
    }

    public void Addition() 
    {
        var Calculator = new Calculator();
        int sum;
        
        Console.Write("Input First Number : ");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second Number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;
        Console.WriteLine($"\n\nSum of Two Numbers : {sum}");
    }
    public void Subtraction() 
    {
        var Calculator = new Calculator();
        int difference;

        Console.Write("Input First Number : ");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second Number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());

        difference = num1 - num2;
        Console.WriteLine($"\n\nDifference of Two Numbers : {difference}");
    }
    public void Multiplication() 
    {
        var Calculator = new Calculator();
        int product;

        Console.Write("Input First Number : ");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second Number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());

        product = num1 * num2;
        Console.WriteLine($"\n\nProduct of Two Numbers : {product}");
    }
    public void Division() 
    {
        var Calculator = new Calculator();
        double quotient;
        double remainder;

        Console.Write("Input First Number : ");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Second Number : ");
        var num2 = Convert.ToInt32(Console.ReadLine());

        quotient = num1 / num2;
        remainder = num1 % num2;
        Console.WriteLine($"\n\nQuotient of Two Numbers : {quotient}");
        Console.WriteLine($"Remainder : {remainder}");
    }
}