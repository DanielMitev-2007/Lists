using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaddd2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(10);
            list.Append(20);
            list.Append(30);
            list.Append(40);
            list.Append(50);
            list.Append(60);
            list.Append(70);


            Console.WriteLine("Connected list: ");
            list.PrintList();

            Console.WriteLine("The middle element is: " + list.FindMiddle());
        }
    }
}
