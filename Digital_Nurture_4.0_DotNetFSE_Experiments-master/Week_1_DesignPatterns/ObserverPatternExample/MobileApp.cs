using System;

public class MobileApp : IObserver
{
    private string user;

    public MobileApp(string user)
    {
        this.user = user;
    }

    public void Update(string stockName, double stockPrice)
    {
        Console.WriteLine($"MobileApp Notification for {user}: {stockName} is now ${stockPrice}");
    }
}
