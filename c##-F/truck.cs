public class truck : Vehicle
{
    public int CargoCapacity{set;get;}
    public truck(string name, int speed) : base(name, speed)
    {
    }
          public override void start()
    {
        Console.WriteLine("The truck's heavy engine rumbles as it starts!" );

    }
}