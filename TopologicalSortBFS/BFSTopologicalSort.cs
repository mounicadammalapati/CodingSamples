using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TopologicalSortBFS
{
   public static class BFSTopologicalSort
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            int[] indegree = new int[numCourses];
            int count = 0;    
                        //[1,0]
            try
            {      
               
                for (int i = 0; i < prerequisites.Length; i++)
                {
                    indegree[prerequisites[i][0]]++;
                }
                int j = prerequisites.Length;
                Console.WriteLine(j);
                //  LinkedList<int> stack = new LinkedList<int>();

                Stack myStack = new Stack();

                for (int i = 0; i < indegree.Length; i++)
                {
                    if (indegree[i] == 0)
                    {
                        myStack.Push(i);
                    }
                }


                while (myStack.Count > 0)
                {
                    int curr = Convert.ToInt32(myStack.Pop());
                    count++;

                    for (int i = 0; i < prerequisites.Length; i++)
                    {
                        if (prerequisites[i][1] == curr)
                        {
                            indegree[prerequisites[i][0]]--;

                            if (indegree[prerequisites[i][0]] == 0)
                            {
                                myStack.Push(prerequisites[i][0]);
                            }
                        }
                    }


                }
                return numCourses == count;
            }

            
            catch (Exception e)
            {
                Console.WriteLine("Exception of the program " + e.InnerException);

                return false;
            }
        }
    }
}
