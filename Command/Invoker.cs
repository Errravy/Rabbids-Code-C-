public class Invoker
{
    private List<ICommand> _command;
    public Invoker()
    {
        _command = new List<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        _command.Add(command);
    }

    public void ExecuteCommands()
    {
        foreach (var command in _command)
        {
            command.Execute();
        }
        _command.Clear();
    }
}
