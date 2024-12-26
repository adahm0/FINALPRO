public class Program{
    public static void Main(string[]arges){
        Vehicle[]ins = new Vehicle[3];
        car c = new car ("car",10);
        Motorcycle m = new Motorcycle("Motorcycle",40);
        truck t = new truck("truck",15);
        ins[0] =c;
      ins[1] =m;
    ins[2] =t;
for (int i = 0; i < ins.Length; i++)
{
    ins[i].start();
}
    ins[0].Accelerate(10);
    ins[1].Accelerate(20);
    ins[2].Accelerate(15);
    for (int i = 0; i < ins.Length; i++)
{
    ins[i].GetSpeed();
}
Console.WriteLine("the total number of vehicles created is : "+ Vehicle.TotalVehicles);


    }
}