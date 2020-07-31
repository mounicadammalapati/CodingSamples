using System;

namespace StringQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculation calculation = new StringCalculation();
            //calculation.Calculate();
            calculation.Calc();

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
