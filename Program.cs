public class Program
{
    public static void Main(string[] args)
    {
        IInteractable washingMachine = Factory.CreateObject(Objects.WashingMachine) as IInteractable;
        washingMachine.React();
    }
}
