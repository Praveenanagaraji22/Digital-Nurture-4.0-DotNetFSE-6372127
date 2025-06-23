using System;

public class WebApp : IObserver
{
    private string user;

    public WebApp(string user)
    {
        this.user = user;
    }

    public void Update(string stockName, double stockPrice)
    {
        Console.WriteLine($"WebApp Alert for {user}: {stockName} price changed to ${stockPrice}");
    }
}
