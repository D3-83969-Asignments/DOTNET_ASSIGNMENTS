using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
       
        public static int menu()
        {
            Console.WriteLine("0.exit");
            Console.WriteLine("1.add");
            Console.WriteLine("2.sub");
            Console.WriteLine("3.multiply");
            Console.WriteLine("4.divide");
            Console.WriteLine("5.enter choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }
        static void Main(string[] args)
        {
               int a = Convert.ToInt32(args[0]);
          int b = Convert.ToInt32(args[1]);
            int choice = 0;
            while ( (choice=menu())!=0)  {
                   switch(choice)
                {
                    case 1:
                        Console.WriteLine("addtion is :" + (a +b));
                        break;
                    case 2:
                        Console.WriteLine("substraction is :"+(a - b));
                        break;
                    case 3:
                        Console.WriteLine("multiplication is :" +( a * b));
                        break;
                    case 4:
                        Console.WriteLine("division is :" + (a / b));
                        break;
                }
            }

        }
    }
}
