using System;

namespace TopologicalSortBFS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCourses = 2;
            //int[][] preRequesties = { [1,0],[] }
            int[][] jaggedArray = new int[][] {
                      new int[] {1,0},    
                    };

            LinkedListp linkedList = new LinkedListp();

           for(int i=1;i<5;i++)
            {
                linkedList.InsertData(i);
            }
            //int[,] preRequesities = new int[,] { { 1,0} };
            // bool result= BFSTopologicalSort.CanFinish(numCourses,jaggedArray);
            //  float result = PacksCode.AverageScore();
            // StringReverse.ReverseAString();
            // CheckTwoArrays.CheckArrays();
            //  BinaryTree binaryTree = new BinaryTree();
            //binaryTree.CreateBinaryTree();
            // MinimumDistance minimumDistance = new MinimumDistance();
            // minimumDistance.CalculateDistance();

          //  ReverseInPlace.ReverseIn();

            Console.ReadKey();
        }
    }
}
