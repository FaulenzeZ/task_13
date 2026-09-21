namespace Zadacha25
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                Console.WriteLine("=");
            }
            else if (A > B)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}