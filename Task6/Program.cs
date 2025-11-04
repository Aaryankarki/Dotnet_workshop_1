// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        //listing
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

        //adding
        fruits.Add("Orange");
        //removing
        fruits.Remove("Banana");
        //for each loop shown
        foreach (string i in fruits)
        {
            Console.WriteLine(i + "");
        }
        Console.WriteLine();
        Dictionary<int, String> fruitDict = new Dictionary<int, string>
        {
            {1,"Apple" },
             {2, "Banana"},
            {3, "Mango"}

        };
          Console.WriteLine();
        fruitDict.Add(4, "Orange");
        foreach(var dt in fruitDict)
        {
              Console.WriteLine($"{dt.Key} -> {dt.Value}");
        }

    }
}
