public class TurnLeft : ICommand
{
    private Directions directions;
    private IControlable _cObj;
    public TurnLeft(IControlable cObj)
    {
        _cObj = cObj;
    }
    public void Execute()
    {
        Rotate();
    }

    public Commands GetEnum()
    {
        return Commands.Left;
    }

    private void Rotate()
    {
        switch (directions)
        {
            case Directions.Up:
                _cObj.SetDirection(180);
                break;
            case Directions.Down:
                _cObj.SetDirection(0);
                break;
            case Directions.Left:
                _cObj.SetDirection(90);
                break;
            case Directions.Right:
                _cObj.SetDirection(270);
                break;
            default:
                break;
        }
    }
}