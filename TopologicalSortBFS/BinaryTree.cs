using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSortBFS
{

    //public class Node
    //{
    //    public Node()
    //    {

    //    }
    //   public Node left { get; set; }
    //   public Node Right { get; set; }
    //   public int Data { get; set; }
    //}
    public class BinaryTree
    {
        public BinaryTree left { get; set; }
        public BinaryTree Right { get; set; }
        public int Data { get; set; }
        public BinaryTree()
        {

        }
        public BinaryTree(int data)
        {
            this.Data = data;
        }

        public void CreateBinaryTree()
        {
            int[] arr1 = { 1, 5, 8, 2, 3 };

            //int arr1 = { };

            this.Data = arr1[0];

            for (int i = 1; i <= arr1.Length-1; i++)
            {
                InsertData(arr1[i]);
            }
            //Console.WriteLine("print Inorder");
            //PrintInorder();
            //Console.WriteLine("Print preorder");
            //PrintPreOrder();
            //Console.WriteLine("Print Postorder");
            //PrintPostOrder();

            //min ,value and //value , Max
          bool returnValue=  ValidateBinaryTree();
            Console.WriteLine("Return value of data :"+returnValue);

            Console.ReadKey();
        }

        public bool ValidateBinaryTree()
        {
            if(left!=null)
            {
                if(left.Data<=Data)
                {
                    left.ValidateBinaryTree();
                }
                else
                {
                    return false;
                }
            }
            if(Right!=null)
            {
                if (Right.Data > Data)
                {
                    Right.ValidateBinaryTree();
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public void InsertData(int value)
        {
            try
            {
                if (value <= this.Data)
                {
                    if (left == null)
                    {
                        left = new BinaryTree(value);
                    }
                    else
                    {
                        left.InsertData(value);
                    }

                }
                else if (value > this.Data)
                {
                    if (Right == null)
                    {
                        Right = new BinaryTree(value);
                    }
                    else
                    {
                        Right.InsertData(value);
                    }
                }

            } catch (Exception e)
            {

            }
        }
        public void PrintInorder()
        {
            if(left!=null)
            {
                left.PrintInorder();
            }

            Console.WriteLine(Data);

            if(Right!=null)
            {
                Right.PrintInorder();
            }
        }

        public void PrintPreOrder()
        {
            //preorder is root, left , right
            Console.WriteLine(Data);
            if (left != null)
            {
                left.PrintPreOrder();
            }
            if(Right!=null)
            {
                Right.PrintPreOrder();
            }

        }

        public void PrintPostOrder()
        {
            if(left!=null)
            {
                left.PrintPostOrder();
            }
            if(Right!=null)
            {
                Right.PrintPostOrder();
            }

            Console.WriteLine(Data);
        }
        //for(int i=1;i<=arr1.Length;i++)
        //{
        //    p = root;

        //    while(true)
        //    {
        //        if (arr1[i] <= p.Data)
        //        {
        //            if (p.left == null)
        //            {
        //                p.left.Data = arr1[i];
        //                break;
        //            }
        //            else
        //            {
        //                p = p.left;
        //            }

        //        }
        //        else if(arr1[i]>=p.Data)
        //        {
        //            if(p.Right==null)
        //            {
        //                p.Right.Data = arr1[i];
        //                break;
        //            }
        //            else
        //            {
        //                p = p.Right;
        //            }

        //        }
        //    }

        //}    

        ////traverse array .. in order is the best for 

    }
       
    }

