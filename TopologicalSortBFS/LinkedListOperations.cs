using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TopologicalSortBFS
{
    public class LinkedListOperations
    {
        public int data;
        public LinkedListOperations next;

        public LinkedListOperations(int data)
        {
            this.data = data;
        }


    }

        public class LinkedListp
        {
           LinkedListOperations head;

           public void InsertData(int a)
           {
              if(head==null)
              {
                head = new LinkedListOperations(a);

                return;
              }
            LinkedListOperations current = head;
            while(current.next!=null)
            {
                Console.WriteLine(current.next.data);
                current = current.next;               
            }
            current.next = new LinkedListOperations(a);
            Console.WriteLine(current.next.data);
            return;            
           }

        public void PreAppend(int data)
        {
            LinkedListOperations linkedListOperationsnew = new LinkedListOperations(data);
            linkedListOperationsnew.next = head;
            head = linkedListOperationsnew;
        }
        public void DeleteNode(int data)
        {
            if( head ==null || head.data==data)
            {
                head = head.next;
                return;
            }

            LinkedListOperations current;

            current = head;
            while(current.next!=null)
            {
                if(current.next.data==data)
                {
                    current.next = current.next.next;
                    return;
                }
                    current = current.next;
                
            }
        }
        }
    
}

