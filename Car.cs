using System;
namespace dz5
{
    internal class Car(string color, string brand) : Vehicle (4, color, brand), IMyCloneable<Car>
    {
        public Car CloneColor(string color)
        {
            var car = (Car)MemberwiseClone();
            car.Color = color;
            return car;
        }

        Car IMyCloneable<Car>.MyClone()
        {
            return new Car(Color, Brand);
        }
    }
}
