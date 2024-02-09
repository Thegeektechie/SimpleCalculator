// See https://aka.ms/new-console-template for more information
Console.WriteLine("==========Welcome To The Geek Technologies Calculator==========");
Console.WriteLine("  ");
Console.WriteLine("  ");
try
{
    string Continual;

    do
    {
        Console.WriteLine("What do you wish to calculate:  ");
        Console.WriteLine("  ");
        Console.Write("Enter your first Operand:  ");
        double firstOperand = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("  ");
        Console.Write("Enter your Operator:(+, -, /, *, %): ");
        string operateSign = Convert.ToString(Console.ReadLine()!);
        Console.WriteLine("  ");
        Console.Write("Enter your Second Operand:  ");
        double secondOperand = Convert.ToDouble(Console.ReadLine());

       
        double result;

        switch (operateSign)
        {
            case "+":

                result = firstOperand + secondOperand;
                Console.WriteLine("The addition of your inputs is " + result);
                break;

            case "-":

                result = firstOperand - secondOperand;
                Console.WriteLine("The subtraction of your inputs is " + result);
                break;

            case "*":

                result = firstOperand * secondOperand;
                Console.WriteLine("The multiplication of your inputs is " + result);
                break;
            case "/":

                result = firstOperand / secondOperand;
                Console.WriteLine("The division of your inputs is " + result);
                break;
            case "%":

                result = firstOperand % secondOperand;
                Console.WriteLine("The remainder of your inputs division is " + result);
                break;

            default: Console.WriteLine("You have entered an invalid Operator");
                break;
        }
        Console.Write("DO YOU WISH TO CONTINUE? Y or N: ");
        Continual = Console.ReadLine()!;
    } while (Continual == "Y" || Continual== "y");


}
catch (Exception e)
{ Console.WriteLine(e.Message);
    
}
