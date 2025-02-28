using StockLibrary;
namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair f = new Chair();
            f.Accept();
            f.Display();
            Stock s = new Stock();
            s.Name = "hell";
        }
    }
    class Test : Stock
    {
        void Accept()
        {
            Name = "kjlj";
            Qty = 44; //not accessible because it is private protected
        }
    }
}
