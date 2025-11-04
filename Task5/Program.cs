// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        
        DateTime birthDate = new DateTime(2004, 12, 18);
        DateTime currentDate = DateTime.Now;
        TimeSpan ageSpan = currentDate - birthDate;
        int ageYear = (int)(ageSpan.TotalDays / 365);

        Console.WriteLine("Birthdate: " + birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + currentDate.ToShortDateString());
        Console.WriteLine("Age: " + ageYear + " years");

        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + newDate.ToShortDateString());
    }
}
