namespace Session1Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3;
            for(int i = 0; i < 8; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3);
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
