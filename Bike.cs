namespace dz5
{
    internal class Bike(string color, string brand) : Vehicle(2, color, brand), IMyCloneable<Bike>
    {
        Bike IMyCloneable<Bike>.MyClone()
        {
            return new Bike(Color, Brand);
        }
    }
}
