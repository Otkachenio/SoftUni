namespace TankManufacturer.Factory
{
    public class RussianTankFactory : TankFactory
    {
        public override Tank CreateTank()
        {
            return new Tank("T 34", 3.3d, 75);
        }
    }
}