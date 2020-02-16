using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList();

            while (true)
            {
                Console.WriteLine("1. Display list");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Insert in an empty list");
                Console.WriteLine("4. Insert at begining");
                Console.WriteLine("5. Insert After which element");
                Console.WriteLine("6. Insert Before which element");
                Console.WriteLine("7. Insert at K-th Position");
                Console.WriteLine("8. Delete First Node Only");
                Console.WriteLine("9. Delete Last Node Only");
                Console.WriteLine("10. Delete Any Node");
                Console.WriteLine("11. Quit");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 11)
                    break;

                switch (choice)
                {
                    case 1:
                        list.Displaylist();
                        break;
                    case 2:
                        list.CountNodes();
                        break;
                    case 3:
                        Console.Write("Enter the Number to be Inserted in empty list : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertInEmptyList(data);
                        break;
                    case 4:
                        Console.Write("Enter the Number to be Inserted at begining : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBegining(data);
                        break;
                    case 5:
                        Console.Write("Enter the Number to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Number after which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data,x);
                        break;
                    case 6:
                        Console.Write("Enter the Number to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the Number before which to insert : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, x);
                        break;
                    case 7:
                        Console.Write("Enter the Number to be inserted : ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the k-th position where to insert : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, k);
                        break;
                    case 8:
                        list.DeleteFirstNode();
                        break;
                    case 9:
                        list.DeleteLastNode();
                        break;
                    case 10:
                        Console.Write("Enter any element to delete from list : ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.DeleteAnyNode(k);
                        break;                        
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Exiting...");
        }
    }
}
