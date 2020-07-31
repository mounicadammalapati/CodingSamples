using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSortBFS
{
    public static class PacksCode
    {

        //Coderpad: given an array scores [][] = {“jerry”,”65”},{“bob”,”91”}, {“jerry”,”23”}, {“Eric”,”83”}} 
        //Find the student with highest average score

        public static float AverageScore()
        {
            try
            {
                string[][] jaggedArray = new string[][] {
                      new string[] {"jerry","65"},
                      new string[] { "bob","91"},
                      new string[] { "jerry","23"},
                      new string[] { "Eric","83"}
                    };
                Dictionary<string, List<int>> keyValuePairs = new Dictionary<string, List<int>>();

                for(int i=0;i<jaggedArray.Length;i++)
                {
                    if(!keyValuePairs.ContainsKey(jaggedArray[i][0]))
                    {
                        List<int> ls = new List<int>();
                        ls.Add(Convert.ToInt32(jaggedArray[i][1]));
                        keyValuePairs.Add(jaggedArray[i][0],ls);
                    }
                    else
                    {
                        keyValuePairs[jaggedArray[i][0]].Add(Convert.ToInt32(jaggedArray[i][1]));
                    }
                }
                int maxValue = 0;

                foreach(var a in keyValuePairs)
                {
                    int len = a.Value.Count;
                    int total = 0;
                    foreach(var i in a.Value)
                    {
                        total = total + i;
                    }

                    total = total / len;
                    if(total>maxValue)
                    {
                        maxValue = total;
                    }
                }


                Console.WriteLine("max value is :" + maxValue);
                      
     

            }
            catch(Exception e)
            {

            }
            return 0;
        }

    }
}
