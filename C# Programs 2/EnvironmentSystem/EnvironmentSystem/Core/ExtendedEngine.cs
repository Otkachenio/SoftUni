namespace EnvironmentSystem.Core
{
    using System;

    using Interfaces;
    using Models.Objects;

    public class ExtendedEngine : Engine
    {
        private IController controller;
        private bool isPaused;

        public ExtendedEngine(int worldWidth,
            int worldHeight ,
            IObjectGenerator<EnvironmentObject> objectGenerator,
            ICollisionHandler collisionHandler,
            IRenderer renderer,
            IController controller) 
                : base(worldWidth, worldHeight, objectGenerator, collisionHandler, renderer)
        {
            this.controller = controller;
            this.AttachControllerEvents();
        }

        public void AttachControllerEvents()
        {
            this.controller.Pause += controller_Pause;
        }
        
        public void controller_Pause(object sender, EventArgs e)
        {
            this.isPaused = !isPaused;
        }

        protected override void ExecuteEnvironmentLoop()
        {
            this.controller.ProcessInput();

            if (!this.isPaused)
            {
                base.ExecuteEnvironmentLoop();
            }           
        }

        protected override void Insert(EnvironmentObject obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("ERROR: Enciroment object cannot be null.");
            }

            base.Insert(obj);
        }
    }
}