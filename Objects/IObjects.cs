public interface IObjects
{
    bool IsSucked();
    void SetPositionX(int x);
    void SetPositionY(int y);
    void SetPosition(int x, int y);
    (int x,int y) GetPosition();
}