namespace NeedForSpeed
{
    class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
            base.DefaultFuelConsumption = 3;
        }
    }
}
