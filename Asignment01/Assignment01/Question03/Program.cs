using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        public static int a;
        public static int b;
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
        public static void display()
        {
            Console.WriteLine("enter number 1 : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2 : ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            
            int choice = 0;
            do
            {

                switch ((choice = menu()))
                {

                    case 1:
                        display();
                        Console.WriteLine("addtion is :" + (a + b));
                        break;
                    case 2:
                        display();
                        Console.WriteLine("substraction is :" + (a - b));
                        break;
                    case 3:
                        display();
                        Console.WriteLine("multiplication is :" + (a * b));
                        break;
                    case 4:
                        display();
                        Console.WriteLine("division is :" + (a / b));
                        break;
                }

            } while (choice != 0);

        }
    }
}
