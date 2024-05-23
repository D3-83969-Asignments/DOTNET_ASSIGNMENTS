namespace Question8
{
    public enum DepartmentType
    {
        HR = 0,  IT, Sales , Marketing

    }
    class Employee : Person
    {
        private static int id = 0;
        double salary ;
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

        Employee()
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

        public  void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter salary");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter designation");
            designation = Console.ReadLine();
            Console.WriteLine("Enter department ");


            Console.WriteLine("Enter Department (0. HR, 1. IT, 2. Sales, 3. Marketing)");
            string departmentinput = Console.ReadLine();
            department = (DepartmentType)Enum.Parse(typeof(DepartmentType), departmentinput, true);

            
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Salary : "+salary);
            Console.WriteLine("Designation : "+designation);
            Console.WriteLine("Department : " + department);
           
        }

    }
}
