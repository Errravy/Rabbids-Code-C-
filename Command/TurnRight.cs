public class TurnRight : ICommand
{
    private IControlable _cObj;
    public TurnRight(IControlable cObj)
    {
        _cObj = cObj;
    }
    public void Execute()
    {
        System.Console.WriteLine("rotate + 90");
    }

    public Commands GetEnum()
    {
        return Commands.Right;
    }
}