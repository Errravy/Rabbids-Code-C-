public class MoveBackward : ICommand
{
    private IControlable _cObj;
    public MoveBackward(IControlable cObj)
    {
        _cObj = cObj;
    }
    public void Execute()
    {
        System.Console.WriteLine("x - 1");
    }

    public Commands GetEnum()
    {
        return Commands.Backward;
    }
}