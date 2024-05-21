namespace Question7
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
}