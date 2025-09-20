internal class Program
{
    private static void Main(string[] args)
    {
        int[,] a = new int[3, 2];
        int i, j;

        Console.WriteLine("enter 6 numbers");
        for (i = 0; i < 3; i++) 
        {
            for (j = 0; j < 2; j++)
            {
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (i = 0; i < 3; ++i)
        {
            for (j = 0; j < 2; ++j)
            {
                Console.Write(a[i, j]);

            }
            Console.WriteLine();

        }
    }
}