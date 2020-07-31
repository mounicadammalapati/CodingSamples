using System;
using System.Collections.Generic;
using System.Text;

namespace StringQuestions
{
    public class StringCalculation
    {
        public int Calculate()
        {
            string str = "3+4-10+12";
            char[] c = { '+', '-' };
            string[] s = str.Split(c);
            int sum = 0;
            int count = 1;
            char[] chr = str.ToCharArray();
            sum = (int)(char.GetNumericValue(chr[0]));

            while (count < chr.Length)
            {
                if (chr[count] == '+')
                {
                    count++;
                    sum = sum + (int)(char.GetNumericValue(chr[count]));
                }
                
                    count++;
                
            }
            Console.WriteLine(sum);
            return sum;
        }

        public int Calc()
        {
            string str = "3-4+10-7";
            char[] allChars = str.ToCharArray();
            char[] c = { '+', '-' };
            string[] numbers = str.Split(c);
            int count = 1;
            int sum = Convert.ToInt32(numbers[0]);
            int i = 0;

            while(count<str.Length)
            {
                if(allChars[count]=='+')
                {
                    count++;
                    i++;
                    sum = sum + Convert.ToInt32(numbers[i]);
                }
                else if(allChars[count]=='-')
                {
                    count++;
                    i++;
                    sum = sum - Convert.ToInt32(numbers[i]);
                }
                count++;        
            }
            Console.WriteLine("sum of the expression is" + sum);
            return sum;
        }
    }
}