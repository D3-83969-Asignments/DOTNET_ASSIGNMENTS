namespace Question05
{
    public struct Student
    {

        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;


        public Student()
        {
            name = "";
            gender = false;
            age = 0;
            std = 0;
            div = '0';
            marks = 0;
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public int _age
        {
            get { return age; }
            set { age = value; }
        }
        public string _name
        {
            get { return name; }
            set { name = value; }
        }

        public bool _gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int _std
        {
            get { return std; }
            set { std = value; }
        }

        public char _div
        {
            get { return div; }
            set { div = value; }
        }

        public double _marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public void AcceptDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter gender  True-Male , False-Female");
            _gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter age");
            _age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter enter standard ");
            _std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter division");
            _div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter marks");
            _marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("name : " + _name);
            if (_gender == true)
            {
                Console.WriteLine("gender : Male");
            }
            else
            {
                Console.WriteLine("gender : Female");
            }

            Console.WriteLine("age : " + _age);
            Console.WriteLine("std : " + _std);
            Console.WriteLine("div : " + _div);
            Console.WriteLine("marks : " + _marks);
        }

    }
    internal class Program
    {


        public static void CreateArray(ref Student[] arr)
        {
            int size;
            Console.WriteLine("Enter the size of array");
            size = Convert.ToInt32(Console.ReadLine());

            arr = new Student[size];

        }
        public static void AcceptInfo(ref Student[] studentarr)
        {
            for (int i = 0; i < studentarr.Length; i++)
            {
                studentarr[i].AcceptDetails();
            }

        }
        public static void PrintInfo(ref Student[] studentarr)
        {
            for (int i = 0; i < studentarr.Length; i++)
            {
                studentarr[i].PrintDetails();
            }
        }

        public static void ReverseArray(ref Student[] studentarr)
        {
            Console.WriteLine("<-------Reverse Array------->");

            for (int i = studentarr.Length - 1; i >= 0; i--)
            {
                studentarr[i].PrintDetails();
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[1];
            CreateArray(ref students);
            AcceptInfo(ref students);
            PrintInfo(ref students);
            ReverseArray(ref students);

        }
    }
}
