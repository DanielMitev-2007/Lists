using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaddd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            Console.WriteLine("Original list: ");
            list.PrintList();

            list.Reverse();

            Console.WriteLine("Reversed list: ");
            list.PrintList();
        }
    }
}
