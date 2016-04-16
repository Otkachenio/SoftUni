namespace TankManufacturer.Factory
{
    public class AmericanTankFactory : TankFactory
    {
        public override Tank CreateTank()
        {
            return new Tank("M1 Abrams ", 5.4d, 120);
        }
    }
}