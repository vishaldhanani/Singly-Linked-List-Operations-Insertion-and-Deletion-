using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class SingleLinkedList
    {
        private Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void Displaylist()
        {
            Node p;

            if (start == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            Console.Write("List is : ");
            p = start;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
            }
        }

        public void CountNodes()
        {
            int n = 0;
            Node p = start;
            while (p != null)
            {
                n++;
                p = p.link;
            }
            Console.WriteLine("Number of Nodes in the List : " + n);
        }

        public void InsertAtBegining(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;

        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                start = temp;
                return;
            }

            p = start;
            while (p.link != null)
            {
                p = p.link;
            }
            p.link = temp;
        }

        public void InsertAfter(int data, int x)
        {
            Node p;
            Node temp = new Node(data);

            p = start;
            while (p != null)
            {
                if (p.info == x)
                    break;
                p = p.link;
            }

            if (p == null)
            {
                Console.WriteLine(x + " is not present in the list.");
            }
            else
            {
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertBefore(int data, int x)
        {
            Node p;
            Node temp = new Node(data);

            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            //If the List has only one node, then need to insert as first node
            if (x == start.info)
            {
                temp.link = start;
                start = temp;
                return;
            }

            //Find the reference of predecessor of node containing x
            p = start;
            while (p.link != null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }
            if (p.link == null)
            {
                Console.WriteLine(x + " is not present in the list.");
            }
            else
            {
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void InsertAtPosition(int data, int k)
        {
            Node p;
            Node temp = new Node(data);
            int i;
            if (k == 1)
            {
                temp.link = start;
                start = temp;
                return;
            }

            p = start;
            for (i = 1; i < k - 1 && p != null; i++) //Find a refe. to k-1 node
                p = p.link;

            if (p == null)
                Console.WriteLine("You can only insert only up to " + i + "-th position.");
            else
            {
                temp.link = p.link;
                p.link = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                return;
            start = start.link;
        }

        public void DeleteLastNode()
        {
            //Empty List
            if (start == null)
                return;

            //Only One Node in the List
            if (start.link == null)
            {
                start = null;
                return;
            }

            // More than 2 node
            Node p = start;
            while (p.link.link != null)
                p = p.link;
            p.link = null;
        }

        public void DeleteAnyNode(int x)
        {
            if(start == null)
            {
                return;
            }

            //deletion of first node
            if(start.info ==x)
            {
                start = start.link;
                return;
            }

            //Deletion of between or at the end
            Node p = start;
            while (p.link!= null)
            {
                if (p.link.info == x)
                    break;
                p = p.link;
            }         
            
            if(p.link ==null)
            {
                Console.WriteLine("Element "+x+" is not in the list");
            }
            else
            {
                p.link = p.link.link;
            }
        }


        public void CreateList()
        {
            int n, data;
            Console.Write("Enter the number of Nodes : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the element to be inserted : ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }
    }
}
