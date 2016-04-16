namespace TankManufacturer.Factory
{
    public abstract class TankFactory
    {
        private Tank tank;

        protected TankFactory()
        {
        }

        public Tank Tank { get; set; }

        public abstract Tank CreateTank();
    }
}