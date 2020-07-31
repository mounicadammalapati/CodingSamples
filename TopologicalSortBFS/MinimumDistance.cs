using System;
using System.Collections.Generic;
using System.Text;


namespace TopologicalSortBFS
{
   public class MinimumDistance
    {
        public string s = "geeks for geeks contribute practice";
        public string s1= "geeks";
        public string s2 = "practice";
        public void CalculateDistance()
        {
            string[] words = s.Split(" ");
            int min_dist = words.Length + 1;

            for(int i=0;i<words.Length;i++)
            {
                if(words[i].Equals(s1))
                {
                    for(int j=0;j<words.Length;j++)
                    {
                        if(words[j].Equals(s2))
                        {
                            int curr = Math.Abs(i - j) - 1;

                            if(curr<min_dist)
                            {
                                min_dist = curr;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("Minium distance is :" + min_dist);
            Console.ReadKey();
        }

        public void MinimumWayCalc()
        {

        }
    }
}
