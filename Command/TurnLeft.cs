public class TurnLeft : ICommand
{
    private IControlable _cObj;
    public TurnLeft(IControlable cObj)
    {
        _cObj = cObj;
    }
    public void Execute()
    {
        System.Console.WriteLine("rotate - 90");
    }

    public Commands GetEnum()
    {
        return Commands.Left;
    }
}