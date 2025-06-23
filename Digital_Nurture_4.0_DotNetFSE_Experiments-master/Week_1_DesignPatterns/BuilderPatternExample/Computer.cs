using System;

public class Computer
{
    private string? cpu;
    private string? ram;
    private string? storage;
    private string? graphicsCard;

    private Computer(Builder builder)
    {
        this.cpu = builder.Cpu;
        this.ram = builder.Ram;
        this.storage = builder.Storage;
        this.graphicsCard = builder.GraphicsCard;
    }

    public override string ToString()
    {
        return $"Computer [CPU={cpu}, RAM={ram}, Storage={storage}, Graphics Card={graphicsCard}]";
    }

    public class Builder
    {
        public string? Cpu { get; private set; }
        public string? Ram { get; private set; }
        public string? Storage { get; private set; }
        public string? GraphicsCard { get; private set; }

        public Builder SetCpu(string cpu)
        {
            Cpu = cpu;
            return this;
        }

        public Builder SetRam(string ram)
        {
            Ram = ram;
            return this;
        }

        public Builder SetStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public Builder SetGraphicsCard(string graphicsCard)
        {
            GraphicsCard = graphicsCard;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}
