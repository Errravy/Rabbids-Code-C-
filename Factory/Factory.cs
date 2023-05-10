public class Factory
{
    public static IObjects CreateObject(Objects type)
    {
        switch (type)
        {
            case Objects.Button:
                return new Button();
            case Objects.ElectricFence:
                return new ElectricFence();
            case Objects.Rabbids:
                return new Rabbids();
            case Objects.IdleRabbids:
                return new IdleRabbids();
            case Objects.WashingMachine:
                return new WashingMachine();
            case Objects.VacuumRobot:
                return new VacuumRobot();
            case Objects.ArmedRabbids:
                return new ArmedRabbids();
            case Objects.ClawRobot:
                return new ClawRobot();
            case Objects.Plunger:
                return new Plunger();
            case Objects.Bomb:
                return new Bomb();
            case Objects.Bag:
                return new Bag();
            case Objects.Bubble:
                return new Bubble();
            case Objects.Soap:
                return new Soap();
            case Objects.CardBox:
                return new CardBox();
            case Objects.Ring:
                return new Ring();
            case Objects.Sausage:
                return new Sausage();
            case Objects.Saw:
                return new Saw();
            case Objects.Tissue:
                return new Tissue();
            case Objects.ToiletPaper:
                return new ToiletPaper();
            case Objects.WateringCan:
                return new WateringCan();
            default:
                return null;
        }
    }

    public static IInteractable CreateInteractable(Interactables type)
    {
        switch (type)
        {
            case Interactables.Button:
                return new Button();
            case Interactables.ElectricFence:
                return new ElectricFence();
            case Interactables.IdleRabbids:
                return new IdleRabbids();
            case Interactables.WashingMachine:
                return new WashingMachine();
            default:
                return null;
        }
    }

    public static IControlable CreateControlable(Controlables type)
    {
        switch (type)
        {
            case Controlables.Rabbids:
                return new Rabbids();
            case Controlables.VacuumRobot:
                return new VacuumRobot();
            case Controlables.ArmedRabbids:
                return new ArmedRabbids();
            case Controlables.ClawRobot:
                return new ClawRobot();
            default:
                return null;
        }
    }

    public static ICommand CreateCommands(IControlable obj, Commands type)
    {
        switch (type)
        {
            case Commands.Forward:
                return obj.SetCommand(new MoveForward(obj));
            case Commands.Backward:
                return obj.SetCommand(new MoveBackward(obj));
            case Commands.Left:
                return obj.SetCommand(new TurnLeft(obj));
            case Commands.Right:
                return obj.SetCommand(new TurnRight(obj));
            default:
                return null;
        }
    }
}