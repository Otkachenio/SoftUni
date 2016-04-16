namespace TankManufacturer.Factory
{
    public class GermanTankFactory : TankFactory
    {
        public override Tank CreateTank()
        {
            return new Tank("Tiger", 4.5d, 120);
        }
    }
}