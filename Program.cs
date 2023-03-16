namespace Do_while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                }
                i++;
            }


        }
    }
}