using System;

class Program
{
    static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("image1.jpg");
        IImage image2 = new ProxyImage("image2.jpg");

        Console.WriteLine("First display of image1:");
        image1.Display();

        Console.WriteLine("\nSecond display of image1:");
        image1.Display();

        Console.WriteLine("\nFirst display of image2:");
        image2.Display();
    }
}
