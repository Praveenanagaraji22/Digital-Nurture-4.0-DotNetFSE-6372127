using System;

class Program
{
    static void Main(string[] args)
    {
        Light livingRoomLight = new Light();

        ICommand lightOn = new LightCommandOn(livingRoomLight);
        ICommand lightOff = new LightCommandOff(livingRoomLight);

        RemoteControl remote = new RemoteControl();

        Console.WriteLine("Turning ON the light:");
        remote.SetCommand(lightOn);
        remote.PressButton();

        Console.WriteLine("Turning OFF the light:");
        remote.SetCommand(lightOff);
        remote.PressButton();
    }
}
