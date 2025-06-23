public class LightCommandOff : ICommand
{
    private Light _light;

    public LightCommandOff(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }
}
