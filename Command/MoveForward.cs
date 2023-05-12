public class MoveForward : ICommand
{
    private IControlable _cObj;
    public MoveForward(IControlable cObj)
    {
        _cObj = cObj;
    }
    public void Execute()
    {
        System.Console.WriteLine("x + 1");
    }

    public Commands GetEnum()
    {
        return Commands.Forward;
    }
}