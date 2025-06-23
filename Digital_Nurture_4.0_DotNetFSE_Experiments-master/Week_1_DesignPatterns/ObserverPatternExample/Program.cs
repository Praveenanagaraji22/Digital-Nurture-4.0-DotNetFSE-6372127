using System;

class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();

        IObserver mobileUser1 = new MobileApp("Alice");
        IObserver webUser1 = new WebApp("Bob");

        stockMarket.RegisterObserver(mobileUser1);
        stockMarket.RegisterObserver(webUser1);

        Console.WriteLine("---- Updating Stock to Apple ----");
        stockMarket.SetStock("Apple", 150.75);

        Console.WriteLine("\n---- Updating Stock to Tesla ----");
        stockMarket.SetStock("Tesla", 999.99);

        stockMarket.RemoveObserver(webUser1);

        Console.WriteLine("\n---- Updating Stock to Google ----");
        stockMarket.SetStock("Google", 1350.50);
    }
}
