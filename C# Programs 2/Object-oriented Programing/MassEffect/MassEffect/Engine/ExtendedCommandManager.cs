namespace MassEffect.Engine
{
    using MassEffect.Engine.Commands;

    public class ExtendedCommandManager : CommandManager
    {
        public override void SeedCommands()
        {
            base.SeedCommands();

            this.commandsByName["system-report"] = new CreateCommand(this.Engine);
        }
    }
}