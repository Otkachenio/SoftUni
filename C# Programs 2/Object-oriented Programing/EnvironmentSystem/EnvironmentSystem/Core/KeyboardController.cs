namespace EnvironmentSystem.Core
{    
    using System;

    using Interfaces;

    public class KeyboardController : IController
    {
        public event EventHandler Pause;

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                var keyPressed = Console.ReadKey();
                if (keyPressed.Key == ConsoleKey.Spacebar)
                {
                    if (this.Pause != null)
                    {
                        this.Pause(this, new EventArgs());
                    }
                }
            }
        }
    }
}