namespace NeedForSpeed
{
    class SportCar : Car
    {
        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
        {
            base.DefaultFuelConsumption = 10;
        }
    }
}
