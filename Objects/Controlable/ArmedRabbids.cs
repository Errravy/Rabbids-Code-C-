public class ArmedRabbids : IControlable
{
    public Dictionary<Commands, ICommand> _command { get; private set; }
    private float _x;
    private float _y;
    private bool _isSucked;

    public ArmedRabbids()
    {
        _x = 0;
        _y = 0;
        _isSucked = false;
        _command = new Dictionary<Commands, ICommand>();
    }
    public ICommand SetCommand(ICommand command)
    {
        if (!_command.ContainsKey(command.GetEnum()))
        {
            _command.Add(command.GetEnum(), command);
            return command;
        }
        return null;

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
        Console.WriteLine($"ArmedRabbids is at {_x}, {_y}");
    }

    public bool IsSucked()
    {
        return _isSucked;
    }
}