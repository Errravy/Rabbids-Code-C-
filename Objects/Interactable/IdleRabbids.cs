public class IdleRabbids : IInteractable
{
    private int _x;
    private int _y;
    private bool _isSucked;
    public IdleRabbids()
    {
        _x = 0;
        _y = 0;
        _isSucked = false;
    }
    public void SetPositionX(int x)
    {
        _x = x;
    }
    public void SetPositionY(int y)
    {
        _y = y;
    }
    public void SetPosition(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public (int x, int y) GetPosition()
    {
        return (_x, _y);
    }
    public void React()
    {
        Console.WriteLine("IdleRabbid activated!");
    }
    public bool IsSucked()
    {
        return _isSucked;
    }
}