public class ElectricFence : IInteractable
{
    private float _x;
    private float _y;
    private bool _isSucked;
    public ElectricFence()
    {
        _x = 0;
        _y = 0;
        _isSucked = false;
    }
    public void SetPositionX(float x)
    {
        _x = x;
    }
    public void SetPositionY(float y)
    {
        _y = y;
    }
    public void SetPosition(float x, float y)
    {
        _x = x;
        _y = y;
    }
    public void GetPosition()
    {
        Console.WriteLine("ElectricFence position: " + _x + ", " + _y);
    }
    public void React()
    {
        Console.WriteLine("ElectricFence activated!");
    }
    public bool IsSucked()
    {
        return _isSucked;
    }
}