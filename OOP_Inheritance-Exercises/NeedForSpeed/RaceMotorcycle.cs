namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
            base.DefaultFuelConsumption = 8;
        }
    }
}
