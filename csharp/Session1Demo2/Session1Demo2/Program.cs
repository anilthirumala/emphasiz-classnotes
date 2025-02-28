namespace Session1Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short a;
            Int16 a;
            long x;
            Int64 x;
            int num, sum = 0,n;
            bool isDone = true;
            Console.WriteLine("enter the limit");
           n = Int32.Parse(Console.ReadLine());
           // n = Convert.ToInt32(Console.ReadLine());
           for(int i = 0; i < n; i++)
            {
                Console.WriteLine("enter the number");
                num = Int32.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"the sum is: {sum}");
            float x;
            Single x;

        }
    }
}
