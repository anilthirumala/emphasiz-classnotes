namespace StockLibrary
{
  public class Stock
    {
     public string Name;
     private protected  float Qty;
        void Check()
        {
            Qty = 8;
        }

    }
    class Items : Stock
    {
         void Add()
        {
            Qty = 44;
            Name = "anil";
        }
    }
}
