using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1,2,3,4,5,9,10";
            Program.SentenceSplit(str);
            Console.WriteLine("Hello World!");
        }

        public static void SentenceSplit(string str)
        {
            char[] operatores = {' ',','};

            // string[] a = str.Split(operatores,5,StringSplitOptions.RemoveEmptyEntries);
            string[] a = str.Split(' ', ',');
            int num = 0;
            
            foreach(var n in a)
            {
                num = num + Convert.ToInt32(n);
            }
            Console.WriteLine("Total sum of the numbers " + num);

           //foreach(var i in a)
           // {
           //     Console.WriteLine(i);
           // }

            Console.ReadKey();

        }
    }

   
}
