public class Tissue : IObjects
{
    private float _x;
    private float _y;
    private bool _isSucked;

    public Tissue()
    {
        _x = 0;
        _y = 0;
        _isSucked = true;
    }
    public void SetPosition(float x, float y)
    {
        _x = x;
        _y = y;
    }

    public void SetPositionX(float x)
    {
        _x = x;
    }

    public void SetPositionY(float y)
    {
        _y = y;
    }

    public void GetPosition()
    {
        Console.WriteLine($"Tissue is at {_x}, {_y}");
    }

    public bool IsSucked()
    {
        return _isSucked;
    }
}