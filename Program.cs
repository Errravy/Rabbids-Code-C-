public class Program
{
    public static void Main(string[] args)
    {
        Rabbids rabbids = new Rabbids();
        Invoker invoker = new Invoker();
        rabbids.SetCommand(new MoveForward(rabbids));
        invoker.AddCommand(rabbids._command[Commands.Forward]);
        invoker.ExecuteCommand();
    }
}
