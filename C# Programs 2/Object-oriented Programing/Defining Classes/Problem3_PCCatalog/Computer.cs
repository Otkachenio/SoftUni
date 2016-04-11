using System;

namespace Problem3_PCCatalog
{
    class Computer
    {
        private string name;
        private Component processor = new Component();
        private Component gPU = new Component();
        private Component motherboard = new Component();
        private Component rAM = new Component();
        private Component hDD = new Component();

        public Computer(string name,
                            string processorModel,
                            decimal processorPrice,
                            string gPUModel,
                            decimal gPUPrice,
                            string motherboardModel,
                            decimal motherboardPrice,
                            string rAMModel,
                            decimal rAMPrice,
                            string hDDModel,
                            decimal hDDPrice)
        {
            this.name = name;
            this.processor.Model = processorModel;
            this.processor.Price = processorPrice;
            this.gPU.Model = gPUModel;
            this.gPU.Price = gPUPrice;
            this.motherboard.Model = motherboardModel;
            this.motherboard.Price = motherboardPrice;
            this.rAM.Model = rAMModel;
            this.rAM.Price = rAMPrice;
            this.hDD.Model = hDDModel;
            this.hDD.Price = hDDPrice;
        }

        public Computer(string name,
                            string processorModel,
                            decimal processorPrice,
                            string gPUModel,
                            decimal gPUPrice,
                            string motherboardModel,
                            decimal motherboardPrice,
                            string rAMModel,
                            decimal rAMPrice,
                            string hDDModel,
                            decimal hDDPrice,
                            string processorDetails = null,
                            string gPUDetails = null,
                            string motherboardDetails = null,
                            string rAMDetails = null,
                            string hDDDetails = null) : this(
                                                        name,
                                                        processorModel,
                                                        processorPrice,
                                                        gPUModel,
                                                        gPUPrice,
                                                        motherboardModel,
                                                        motherboardPrice,
                                                        rAMModel,
                                                        rAMPrice,
                                                        hDDModel,
                                                        hDDPrice)
        {
            this.processor.Details = processorDetails;
            this.gPU.Details = gPUDetails;
            this.motherboard.Details = motherboardDetails;
            this.rAM.Details = rAMDetails;
            this.hDD.Details = hDDDetails;
        }

        public decimal Price
        {
            get
            {
                return (processor.Price + gPU.Price + motherboard.Price + rAM.Price + hDD.Price);
            }
        }

        public override string ToString()
        {
            Console.WriteLine("Procesor: " + processor.Model + ", price: " + processor.Price + "$");
            Console.WriteLine("Video card: " + gPU.Model + ", price: " + gPU.Price + "$");
            Console.WriteLine("Motherboard: " + motherboard.Model + ", price: " + motherboard.Price + "$");
            Console.WriteLine("RAM: " + rAM.Model + ", price: " + rAM.Price + "$");
            Console.WriteLine("Hard Disk Drive: " + hDD.Model + ", price: " + hDD.Price + "$");
            Console.WriteLine("----------------------");
            Console.WriteLine("Full Price: {0}$", Price);
            return "";
        }
    }
}