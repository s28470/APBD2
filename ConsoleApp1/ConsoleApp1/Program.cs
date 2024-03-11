class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bye world!");
        Console.WriteLine("Bye world!");
        Console.WriteLine("Bye world!");
    }


    public static double FindAverage(int[] tab) {
        double average = 0;
        foreach (var i in tab) {
            average += i;
        }

        return average / tab.Length;
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