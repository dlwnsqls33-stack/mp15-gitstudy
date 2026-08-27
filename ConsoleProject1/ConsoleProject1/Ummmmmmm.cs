namespace ConsoleProject1;

public class Ummmmmmm : Monster
{

    public Ummmmmmm()
    {
        Health = 20;
        Damage = 20;
        Speed = 20;
    }

    public override void canJump(int value)
    {
        base.canJump(int.Parse(value.ToString()));
    }
}