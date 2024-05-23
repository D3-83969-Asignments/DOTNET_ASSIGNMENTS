namespace Question9
{
    public class Date
    {
        private int year;
        private int month;
        private int day;

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day { get => day; set => day = value; }

        public Date()
        {

        }

        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter Day");
            Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date Accepted");
        }

        public void PrintDate()
        {
            Console.WriteLine(Day + "/" + Month + "/" + Year);
        }

        public string toString()
        {
            return "[ Date : " + day + "/" + month + "/" + year + "]";
        }

        public bool IsValid()
        {
            return year != 0 && month != 0 && day != 0;
        }

        public static int operator -(Date d1)
        {

            return DateTime.Now.Year - d1.year;
        }
    }
    public class Person
    {
        string _name;
        bool _gender;
        Date _birth;
        string _address;

        public Person()
        {
            _name = string.Empty;
            _gender = false;
            _birth = new Date();
            _address = string.Empty;

        }

        public Person(string name, bool gender, Date birth, string address)
        {
            _name = name;
            _gender = gender;
            _birth = birth;
            _address = address;
        }

        public string Name { get => _name; set => _name = value; }
        public bool Gender { get => _gender; set => _gender = value; }
        public Date Birth { get => _birth; set => _birth = value; }
        public string Address { get => _address; set => _address = value; }


        public void Accept()
        {
            Console.WriteLine("Enter name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter gender True-Male False= female");
            _gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Date of birth");
            _birth.AcceptDate();
            Console.WriteLine("Enter Adress");
            _address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Name : " + _name);
            if (Gender)
                Console.WriteLine("Gender : Male");
            else
                Console.WriteLine("Gender : Female");

            Console.WriteLine("Date of birth:");
            _birth.PrintDate();

            Console.WriteLine("Age : " + (-_birth));


        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Birth)}={Birth}, {nameof(Address)}={Address}}}";
        }
    }

    public enum DepartmentType
    {
        HR = 0, IT, Sales, Marketing

    }
   public class Employee : Person
    {
        private static int id = 0;
        double salary;
        string designation;
        DepartmentType department;

        public Employee(double salary, string designation, DepartmentType department, string name, bool gender, Date birth, string address)
        {
            this.salary = salary;
            this.designation = designation;
            this.department = department;
            this.Name = name;
            this.Gender = gender;
            this.Birth = birth;
            this.Address = address;


        }

        public Employee()
        {

            salary = 0;
            id++;
            designation = "";
        }

        public static int Id { get => id; set => id = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Designation { get => designation; set => designation = value; }
        public DepartmentType Department { get => department; set => department = value; }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Department)}={Department.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Birth)}={Birth}, {nameof(Address)}={Address}}}";
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter designation");
            //designation = Console.ReadLine();
           


            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing)");
            string departmentinput = Console.ReadLine();
            department = (DepartmentType)Enum.Parse(typeof(DepartmentType), departmentinput, true);


        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Salary : " + salary);
            Console.WriteLine("Designation : " + designation);
            Console.WriteLine("Department : " + department);

        }

    }

   public class Manager : Employee
    {
        private double _bonus;

        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }


        public Manager()
        {
            Designation = "Manager";
        }

        public Manager(double bonus)
        {
            _bonus = bonus;
        }

        public void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter bonus");
            _bonus = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Bonus : " + _bonus);

        }

        public override string ToString()
        {
            return $"{{{nameof(Bonus)}={Bonus.ToString()}, {nameof(Id)}={Id.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Department)}={Department.ToString()}, {nameof(Name)}={Name}, {nameof(Gender)}={Gender.ToString()}, {nameof(Birth)}={Birth}, {nameof(Address)}={Address}}}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
