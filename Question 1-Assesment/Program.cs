class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 130; i++)
        {
            if(i % 3 == 0) 
            {
                Console.WriteLine("Hot");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine( "Chocolate");
            }
            else
            { Console.WriteLine(i); }


        }
        Console.ReadKey();
    }
}
