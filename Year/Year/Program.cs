using System.Xml.Linq;

namespace Year
{
  
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter your birth  year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter your birht month : ");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter your birht  day  :");
            int birthDay = int.Parse(Console.ReadLine());
            Console.Clear();

            DateTime dateTime1 = new DateTime(birthYear, birthMonth, birthDay);

            int nowYear = DateTime.Now.Year;
            int nowMonth = DateTime.Now.Month;
            int nowDay = DateTime.Now.Day;
            if (nowDay > birthDay)
            {
                nowDay -= birthDay;
            }
            else
            {
                nowDay = nowDay + 30 - birthDay;
                nowMonth -= 1;
            }
            if (nowMonth > birthMonth)
            {
                nowMonth -= birthMonth;
            }
            else
            {
                nowMonth += 12 - birthMonth;
                nowYear -= 1;
            }
            nowYear -= birthYear;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($" Year: {nowYear} Month: {nowMonth} Day: {nowDay}");
        }
    }
}