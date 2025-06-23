using System;

class Program
{
    static void Main(string[] args)
    {
        Computer basicComputer = new Computer.Builder()
            .SetCpu("Intel i3")
            .SetRam("4GB")
            .SetStorage("500GB HDD")
            .Build();

        Computer gamingComputer = new Computer.Builder()
            .SetCpu("Intel i9")
            .SetRam("32GB")
            .SetStorage("2TB SSD")
            .SetGraphicsCard("NVIDIA RTX 4090")
            .Build();

        Console.WriteLine("Basic Computer: " + basicComputer);
        Console.WriteLine("Gaming Computer: " + gamingComputer);
    }
}
