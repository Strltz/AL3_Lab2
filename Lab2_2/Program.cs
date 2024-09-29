using Lab2_2;

double[] coords1 = new double[2];

Console.WriteLine("Enter type of vehicle");
string type_vehicle1 = Console.ReadLine();

Console.WriteLine("Enter latitude");
coords1[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter longitude");
coords1[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter price");
int price1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter max. speed");
int speed1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the year of manufacture");
int year1 = int.Parse(Console.ReadLine());

Vehicle vehicle1 = new Vehicle(coords1, price1, speed1, year1);

switch (type_vehicle1)
{
    case "car":
        vehicle1 = new Car(coords1, price1, speed1, year1);
        break;
    case "plane":
        Console.WriteLine("Enter max. height");
        int height1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter passanger capacity");
        int num_pas1_p = int.Parse(Console.ReadLine());
        vehicle1 = new Plane(coords1, price1, speed1, year1, height1,
            num_pas1_p);
        break;
    case "ship":
        Console.WriteLine("Enter passanger capacity");
        int num_pas1_s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of seaport");
        int port1 = int.Parse(Console.ReadLine());
        vehicle1 = new Ship(coords1, price1, speed1, year1,
            num_pas1_s, port1);
        break;
}

vehicle1.print_all();
