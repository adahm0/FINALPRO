public class car:Vehicle{
    public int FuelEfficiency{set;get;}
    public car(string name, int speed) : base(name, speed)
    {
    }
    public override void start()
    {
        Console.WriteLine("The car is starting with a smooth engine sound!" );
    }

}