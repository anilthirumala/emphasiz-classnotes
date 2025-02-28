using StockLibrary;
namespace AbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add(444, 5);
            Add(3, 4, 4);
           
            int i = 0; ;
            int choice;
            // Chair []c = new Chair[5];
            //BookShelf [] b = new BookShelf[5]; 
            Furniture []f = new Furniture[3]; 
            while (i < 3)
            {
                Console.WriteLine("Enter your Choice 1.Chair 2.BookShelf");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //code accept chair data
                        f[i] = new Chair();
                        f[i].Accept();
                        break;
                    case 2:
                        // code to accept bookshelf data
                        f[i] = new BookShelf();
                        f[i].Accept();
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }              
                i++;
            }
            foreach(Furniture cc in f)
            {
                cc.Display();
            }
             
        }
        static void Add(int a, int b)
        {
            Console.Write(a + b);
        }
        static void Add(int a, int b, int c)
        {
            Console.Write(a + b + c);
        }
    }
    class Test : Stock
    {
        void Accept()
        {
            Name = "kjlj";
           // Qty = 44; //not accessible because it is private protected
        }
    }
}
