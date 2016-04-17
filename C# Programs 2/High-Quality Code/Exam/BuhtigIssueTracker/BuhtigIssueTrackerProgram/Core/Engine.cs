namespace BuhtigIssueTrackerProgram.Core
{
    using System;
    using System.IO;

    using BuhtigIssueTrackerProgram.Interfaces;
    using BuhtigIssueTrackerProgram.UserInterface;

    public class Engine : IEngine
    {
        private EndPointActionDispatcher dispatcher;
        private IUserInterface userInterface;

        public Engine(EndPointActionDispatcher dispatcher, IUserInterface userInterface)
        {
            this.dispatcher = dispatcher;
            this.userInterface = userInterface;
        }

        public Engine()
            : this(new EndPointActionDispatcher(), new ConsoleUserInterface())
        {
            // DI: Added IUserInterface, ConsoleUserInterface type
            // and made the egine costructor take a user interface using DI
        }      

        public void Run()
        {             
            while (true)
            {
                string url = null;
                url = this.userInterface.ReadLine();
                if (url == null)
                {
                    break;
                }

                url = url.Trim();

                if (!string.IsNullOrEmpty(url))
                {
                    try
                    {
                        var endpoint = new Endpoint(url);
                        string viewResult = this.dispatcher.DispatchAction(endpoint);

                        this.userInterface.WriteLine(viewResult);
                    }
                    catch (Exception ex)
                    {
                        this.userInterface.WriteLine(ex.Message);
                    }
                }
            }               
        }
    }
}