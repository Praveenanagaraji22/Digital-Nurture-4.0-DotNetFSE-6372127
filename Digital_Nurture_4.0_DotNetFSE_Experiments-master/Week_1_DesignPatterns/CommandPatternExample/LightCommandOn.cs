public class LightCommandOn : ICommand
{
    private Light _light;

    public LightCommandOn(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }
}
