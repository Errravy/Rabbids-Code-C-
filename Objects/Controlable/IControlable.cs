public interface IControlable : IObjects
{
    ICommand SetCommand(ICommand command);
}