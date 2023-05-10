public class MoveForward : ICommand
{
    private IObjects _obj;
    public MoveForward(IObjects obj)
    {
        _obj = obj;
    }
    public void Execute()
    {
        System.Console.WriteLine("Maju maju maju");
    }

    public Commands GetEnum()
    {
        return Commands.Forward;
    }
}