using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSortBFS
{
   public static class ReverseInPlace
   
    {
        public static void ReverseIn()
        {

            int[] nums = { 3, 30, 34, 5, 9 };
            nums[0].ToString();

            List<string> ls = new List<string>();
            ls.Add("3");
            ls.Add("30");
            ls.Add("34");
            ls.Add("5");
            ls.Add("9");

            ls.Sort(MyCompare);

            foreach (var a in ls)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();

            //string xy = "";
            //string yx = "";

            //string max = "";

            //for (int i = 0; i < nums.Length; i++)
            //{

            //    xy = xy + nums[i];
            //    yx = nums[i] + yx;

            //    int c = xy.CompareTo(yx);

            //    if (c > 0)
            //    {
            //        max = xy;       
            //    }
            //    else
            //    {
            //        max = yx;        
            //    }
            //}
            //Console.WriteLine(max);
            //Console.ReadKey();
        }
        internal static int MyCompare(string X, string Y)
        {
            // first append Y at the end of X  
            string XY = X + Y;

            // then append X at the end of Y  
            string YX = Y + X;

            // Now see which of the two formed numbers is greater  
            return XY.CompareTo(YX) > 0 ? -1 : 1;
        }


        //int[] arr = {1,3,4,5,7 };
         ///7,5,4,3,1

        //for(int i=0; i<arr.Length/2;i++)
        //{
        //    int temp = arr[i];
        //    arr[i] = arr[arr.Length - i-1];
        //    arr[arr.Length - i-1] = temp;
        //}
        //string str = "";

        //for(int j=0; j<arr.Length;j++)
        //{
        //    Console.WriteLine(arr[j]);

        //}
        //Console.ReadKey();
    }

}

