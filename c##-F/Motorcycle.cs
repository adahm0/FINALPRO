public class Motorcycle : Vehicle
{
    public Motorcycle(string name, int speed) : base(name, speed)
    {
    }
      public override void start()
    {
        Console.WriteLine("The motorcycle roars to life!" );

    }
          public override void Accelerate(int increment){
            if(increment<10)
            base.Accelerate(increment);

          }

}