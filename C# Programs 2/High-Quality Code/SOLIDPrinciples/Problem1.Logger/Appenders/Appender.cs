namespace Problem1.Logger.Appenders
{
    using System;

    using Interfaces;
    using Utils;

    public abstract class Appender
    {
        private ILayout layout;
        private ReportLevels reportLevel = ReportLevels.Info;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public ILayout Layout
        {
            get
            {
                return this.layout;
            }

            set
            {
                this.layout = value;
            }
        }

        public abstract void AppendMessage(ReportLevels level, string message);
        public ReportLevels ReportLevel
        {
            get
            {
                return this.reportLevel;
            }

            set
            {
                this.reportLevel = value;
            }
        }
    }
}