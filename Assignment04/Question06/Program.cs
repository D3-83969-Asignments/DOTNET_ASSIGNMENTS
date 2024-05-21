using System;

public class Date
{
    private int day;
    private int month;
    private int year;

    // Default constructor
    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }

    // Parameterized constructor
    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // Properties
    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public int Month
    {
        get { return month; }
        set { month = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }

    // AcceptDate method to accept data from console
    public void AcceptDate()
    {
        Console.Write("Enter day: ");
        day = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        year = int.Parse(Console.ReadLine());
    }

    // PrintDate method to print data to console
    public void PrintDate()
    {
        Console.WriteLine($"Date: {day:D2}/{month:D2}/{year}");
    }

    // IsValid method to check validity of date
    public bool IsValid()
    {
        if (year < 1 || month < 1 || month > 12 || day < 1)
        {
            return false;
        }

        int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (IsLeapYear(year))
        {
            daysInMonth[2] = 29;
        }

        return day <= daysInMonth[month];
    }

    // Helper method to check if a year is a leap year
    private bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // ToString method to return data of object in string format
    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year}";
    }

    // Static method to return difference between two dates in number of years
    public static int DifferenceInYears(Date d1, Date d2)
    {
        return Math.Abs(d1.year - d2.year);
    }

    // Overload "-" operator to perform the same job
    public static int operator -(Date d1, Date d2)
    {
        return DifferenceInYears(d1, d2);
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        Date date1 = new Date(15, 5, 2000);
        Date date2 = new Date();
        date2.AcceptDate();

        date1.PrintDate();
        date2.PrintDate();

        if (date1.IsValid() && date2.IsValid())
        {
            Console.WriteLine($"Difference in years: {date1 - date2}");
        }
        else
        {
            Console.WriteLine("One or both of the dates are invalid.");
        }
    }
}
