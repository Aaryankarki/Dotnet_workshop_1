// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        //array
        int[] favourite = { 12, 3, 4, 5, 6, 7 };
        //sorting
        Array.Sort(favourite);
        Console.Write("Sorted array: ");
        for (int i=0; i< favourite.Length;i++)
        {
            Console.Write(favourite[i]+" ");
        }
        Console.WriteLine();
        //reverse
        Array.Reverse(favourite);
         Console.Write("Reversed array: ");
       for (int i = 0; i < favourite.Length; i++)
        {
            Console.Write(favourite[i]+" " );
        }
        Console.WriteLine();
        //to findout the array of specific index
        int newIndex = Array.IndexOf(favourite, 3);
            Console.WriteLine("Index of 5: " + newIndex);

        
    }
}
