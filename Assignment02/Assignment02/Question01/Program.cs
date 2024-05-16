using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{

    internal struct Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("kaaran", 10, 23, "male", 'A', 99.55);
            Student student = new Student();
            student.accept();
            student.display();
        }
    }

    public class Student {
        private int std;
        private int age;
        private double marks;
        private string gender;
        private string name;
        private char div;

        public Student()
        {

        }
        public Student(string name,int std,int age,string gender,char div,double marks)
        {
            this.name = name;
            this.std = std; 
            this.age = age; 
            this.gender = gender;  
            this.marks = marks;
            this.div = div;
        }

        public int MyProperty
        {
            get { return std; }
            set { std = value; }
        }

        public String MyProperty2
        {
            get { return name; }
            set { name = value; }
        }
        public String MyProperty5
        {
            get { return gender; }
            set { gender = value; }
        }

        public int MyProperty3
        {
            get { return age; }
            set { age = value; }
        }

        public char MyProperty4
        {
            get { return div; }
            set { div = value; }
        }

        public double MyProperty6
        {
            get { return marks; }
            set { marks = value; }
        }
        public void display()
        {
            Console.WriteLine("name :" + name +", age : "+age+", gender : "+gender+", div : "+ div + ", std : "+std+" marks :"+marks  );
        }
        public void accept()
        {
            Console.WriteLine("enter name : ");
            this.name = Console.ReadLine();
            Console.WriteLine("enter age : ");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter gender : ");
            this.gender = Console.ReadLine();
            Console.WriteLine("enter div : ");
            this.div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter std : ");
            this.std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter marks : ");
            this.marks= Convert.ToDouble(Console.ReadLine());
        }
    }
}
