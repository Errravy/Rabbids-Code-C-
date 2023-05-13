public class Bomb : IObjects
{
    private string objectSymbol = "BO";
    private int _x;
    private int _y;
    private bool _isSucked;

    public Bomb()
    {
        _x = 0;
        _y = 0;
        _isSucked = true;
    }
    public void SetPosition(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public void SetPositionX(int x)
    {
        _x = x;
    }

    public void SetPositionY(int y)
    {
        _y = y;
    }

    public (int x, int y) GetPosition()
    {
        return (_x, _y);
    }

    public bool IsSucked()
    {
        return _isSucked;
    }

    public string GetObjectSymbol()
    {
        return objectSymbol;
    }
}