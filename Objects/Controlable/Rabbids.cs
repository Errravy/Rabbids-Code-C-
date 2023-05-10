public class Rabbids : IControlable
{
    public Dictionary<Commands, ICommand> _command {get;private set;}
    private float _x;
    private float _y;

    public Rabbids()
    {
        _command = new Dictionary<Commands, ICommand>();
    }
    public ICommand SetCommand(ICommand command)
    {
        _command.Add(command.GetEnum(), command);
        return command;
    }

    public void SetPosition(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public void SetPositionX(float x)
    {
        _x = x;
    }

    public void SetPositionY(float y)
    {
        _y = y;
    }

    public void GetPosition()
    {
        Console.WriteLine($"Rabbids is at {_x}, {_y}");
    }
}