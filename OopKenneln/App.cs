namespace OopKenneln;

public class App
{
    public void Run()
    {
        var kennel = new Kennel();
        var ui = new UI(kennel);
        ui.Run();
    }
}