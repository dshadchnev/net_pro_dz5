namespace dz5
{
    internal class Vehicle(int numberOfWheels, string color, string brand) : IMyCloneable<Vehicle>, ICloneable
    {
        public int NumberOfWheels = numberOfWheels;
        
        public string Color = color;
        
        public string Brand = brand;

        public object Clone()
        {
            return (Vehicle)MemberwiseClone();
        }

        public Vehicle MyClone()
        {
            return new Vehicle(NumberOfWheels, Color, Brand);
        }

        public override string ToString()
        {
            return $"Транспортное средство с {NumberOfWheels} колёсами, цвет {Color}, марка {Brand}.";
        }
    }
}
