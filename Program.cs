public class Program
{
    public static void Main(string[] args)
    {
        IControlable armed = Factory.CreateControlable(Controlables.ArmedRabbids);
        Invoker invoker = new Invoker();

        ICommand forward = Factory.CreateCommands(armed, Commands.Forward);
        ICommand backward = Factory.CreateCommands(armed, Commands.Backward);
        ICommand tLeft = Factory.CreateCommands(armed, Commands.Left);
        ICommand tRight = Factory.CreateCommands(armed, Commands.Right);

        invoker.AddCommand(forward);
        invoker.AddCommand(tLeft);
        invoker.AddCommand(forward);
        invoker.AddCommand(backward);
        invoker.AddCommand(forward);
        invoker.AddCommand(tRight);
        invoker.AddCommand(forward);

        invoker.ExecuteCommands();
    }
}
