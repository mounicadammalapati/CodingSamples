using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSortBFS
{
   public static class StringReverse
    {
        public static void ReverseAString()
        {
           // string s = "ke.this.program.very.much."
                      //  +"pqr.mno";

            string s = "i like this program very much";
            string[] splited = s.Split(" ");

            for(int i= 0;i < splited.Length;i++)
            {
                string str = splited[i].ToString();
                string reverseStr = "";
                for(int j=str.Length-1;j>=0;j--)
                {
                    reverseStr = reverseStr + str[j];
                }
                splited[i] = reverseStr;
            }
            StringBuilder stringBuilder1 = new StringBuilder();
           
            for(int a=0;a<splited.Length;a++)
            {
                stringBuilder1.Append(splited[a]);
                stringBuilder1.Append(" ");
            }

            
            for(int i=stringBuilder1.Length-1;i>=0;i--)
            {
                Console.WriteLine(stringBuilder1[i]);
            }
            

            StringBuilder stringBuilder = new StringBuilder();
             
            //output of the string is "much very program this like i"





        }

    }
}
