namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num = 4;
            Pintar(num);
            Console.WriteLine(Pintar);
        }

        static void Pintar(int num)
        {
            for (int i = 0; i < num; i++)
            {


                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }











    }



}
