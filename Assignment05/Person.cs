namespace Question8
{
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
}
