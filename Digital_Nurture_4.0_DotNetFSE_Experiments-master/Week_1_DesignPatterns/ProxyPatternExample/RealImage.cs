using System;

public class RealImage : IImage
{
    private string filename;

    public RealImage(string filename)
    {
        this.filename = filename;
        LoadFromRemoteServer();
    }

    private void LoadFromRemoteServer()
    {
        Console.WriteLine("Loading image from remote server: " + filename);
    }

    public void Display()
    {
        Console.WriteLine("Displaying image: " + filename);
    }
}
