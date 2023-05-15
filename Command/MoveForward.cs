public class MoveForward : ICommand
{
    private Directions directions;
    private IControlable _cObj;
    public MoveForward(IControlable cObj)
    {
        _cObj = cObj;
    }
    public void Execute()
    {
        MoveByDirection();
    }

    public Commands GetEnum()
    {
        return Commands.Forward;
    }

    private void MoveByDirection()
    {
        switch (directions)
        {
            case Directions.Up:
                _cObj.SetPositionY(_cObj.GetPosition().y - 1);
                break;
            case Directions.Down:
                _cObj.SetPositionY(_cObj.GetPosition().y + 1);
                break;
            case Directions.Left:
                _cObj.SetPositionX(_cObj.GetPosition().x - 1);
                break;
            case Directions.Right:
                _cObj.SetPositionX(_cObj.GetPosition().x + 1);
                break;
            default:
                break;
        }
    }
}