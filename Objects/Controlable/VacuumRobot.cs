public class VacuumRobot : IControlable
{
    private string objectSymbol = "V";
    public Dictionary<Commands, ICommand> _command { get; private set; }
    private int _x;
    private int _y;
    private Directions _z;
    private bool _isSucked;

    public VacuumRobot()
    {
        _x = 0;
        _y = 0;
        _z = Directions.Right;
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

    public ICommand GetCommand(Commands commands)
    {
        return _command[commands];
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

    public void SetDirection(int direction)
    {
        switch (direction)
        {
            case 0:
                _z = Directions.Right;
                break;
            case 90:
                _z = Directions.Down;
                break;
            case 180:
                _z = Directions.Left;
                break;
            case 270:
                _z = Directions.Up;
                break;
            default:
                Console.WriteLine("Invalid direction!");
                break;
        }
    }

    public Directions GetDirection()
    {
        return _z;
    }

    public bool IsSucked()
    {
        return _isSucked;
    }

    public string GetObjectSymbol()
    {
        return objectSymbol;
    }
}