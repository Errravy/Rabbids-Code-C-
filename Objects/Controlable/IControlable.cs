public interface IControlable : IObjects
{
    ICommand SetCommand(ICommand command);
    ICommand GetCommand(Commands commands);
    void SetDirection(int direction);
    Directions GetDirection();
}