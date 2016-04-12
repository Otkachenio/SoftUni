namespace Problem1.Logger.Appenders
{
    using System;
    using System.IO;

    using Interfaces;
    using Utils;

    public class FileAppender : Appender
    { 
        private string file;

        public FileAppender(ILayout layout) : base(layout)
        {
        }

        public override void AppendMessage(ReportLevels level, string message)
        {
            using (StreamWriter file = new StreamWriter(this.File, true))
            {
                file.WriteLine(Layout.MessageFormat(DateTime.Now, level, message));
            }
        }

        public string File
        {
            get { return this.file; }

            set
            {
                if (string.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentNullException("File cannot be null.");
                }

                this.file = value;
            }
        }
    }
}
