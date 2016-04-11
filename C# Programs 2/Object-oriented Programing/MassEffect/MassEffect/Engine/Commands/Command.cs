namespace MassEffect.Engine.Commands
{
    using System;
    using System.Linq;

    using MassEffect.Interfaces;
    using MassEffect.Exceptions;

    public abstract class Command
    {
        protected Command(IGameEngine gameEngine)
        {
            this.GameEngine = gameEngine;
        }

        public IGameEngine GameEngine { get; set; }

        public abstract void Execute(string[] commandArgs);

        protected IStarship GetStarshipByName(string name)
        {
            return this.GameEngine.Starships.First(ship => ship.Name == name);
        }

        protected void ValidateAlive(IStarship ship)
        {
            if (ship.Health <= 0)
            {
                throw new ShipException(Messages.ShipAlreadyDestroyed);
            }
        }
    }   
}