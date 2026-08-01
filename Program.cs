namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Реализация паттерна Prototype ***");

            Car red_car = new Car("red", "Ferrari");
            Console.WriteLine(red_car);
            Car black_car = red_car.CloneColor("black");
            Console.WriteLine(black_car);
            Car red_car_2 = (Car)red_car.Clone();
            Console.WriteLine(red_car_2);
            Car red_vehicle = ((IMyCloneable<Car>)red_car).MyClone();
            Console.WriteLine(red_vehicle);
        }
    }
}
