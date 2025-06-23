using System;
using System.Collections.Generic;

public class StockMarket : IStock
{
    private List<IObserver> observers = new List<IObserver>();
    private string? stockName;
    private double stockPrice;

    public void SetStock(string stockName, double stockPrice)
    {
        this.stockName = stockName;
        this.stockPrice = stockPrice;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName!, stockPrice);
        }
    }
}
