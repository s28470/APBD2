class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bye world!");
        Console.WriteLine("Bye world!");
        Console.WriteLine("Bye world!");
    }


    public static double FindAverage(int[] array) {
        double average = 0;
        foreach (var i in array) {
            average += i;
        }

        return average / array.Length;
    }

    public static int FindMax(int[] tab)
    {
        int max = tab[0];
        foreach (var i in tab)
        {
            if (i > max)
            {
                max = i;
            }    
        }

        return max;
    }
    
    
    
    
}