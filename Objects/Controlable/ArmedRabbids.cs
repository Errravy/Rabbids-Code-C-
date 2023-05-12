public class ArmedRabbids : IControlable
{
    public Dictionary<Commands, ICommand> _command { get; private set; }
    private int _x;
    private int _y;
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

    public void SetPosition(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public void SetPositionX(int x)
    {
        _x = x;
    }

    public void SetPositionY(int y)
    {
        _y = y;
    }

    public (int x, int y) GetPosition()
    {
        return (_x, _y);
    }

    public bool IsSucked()
    {
        return _isSucked;
    }
}