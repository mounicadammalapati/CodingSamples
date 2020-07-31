using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSortBFS
{
    public static class CheckTwoArrays
    {
        public static void CheckArrays()
        {
            int[] ar1 = { 1,2,1,2,3};
            int[] ar2 = { 2,1,1,2,4};

            Array.Sort(ar1);
            Array.Sort(ar2);


            for(int i=0;i<ar1.Length;i++)
            {
                if(ar1[i]!=ar2[i])
                {
                    Console.WriteLine("arrays doesnot match");
                }
            }

            Console.ReadKey();
        }

    }
}
