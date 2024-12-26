public class Vehicle{
    public string name{set;get;}
    private int speed{set;get;}

     public static int TotalVehicles;
    public Vehicle(string name, int speed){
        this.name= name;
        this.speed = speed;
    
    }
    public virtual void start(){
        Console.WriteLine("Vehicle is starting!" );

    }
    public virtual void  Accelerate(int increment){
Console.WriteLine("the increment is : "+ speed);
    }
    public int GetSpeed(){
        return speed;
    }
}