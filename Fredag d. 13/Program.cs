namespace Fredag_d._13_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gets the date today and the date in 10 years
            DateTime now = DateTime.Now;
            DateTime year2032 = now.AddYears(10);

            //A string where all the date with end up in
            string fridays = "";

            //checks all day from now to the date in 10 years for friday the 13th
            while (now != year2032)
            {
                now = now.AddDays(1);
                if (now.DayOfWeek == DayOfWeek.Friday && now.Day == 13)
                {
                    fridays += $"{now.Day}/{now.Month}/{now.Year}\r\n";

                }
            }
            //Prints result in the console
            Console.WriteLine($"{fridays}");

            //does so the program doesn't close instantly
            Console.Read();
        }
    }
}