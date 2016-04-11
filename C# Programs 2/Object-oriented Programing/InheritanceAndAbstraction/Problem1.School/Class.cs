using System;
using System.Collections.Generic;

namespace Problem1.School
{
    class Class
    {
        private Teacher teacher;
        private string textIdentifier;
        private Dictionary<string, Teacher> dictionary = new Dictionary<string, Teacher>();

        public Class(string textIdentifier, Teacher teacher)
        {
            this.teacher = teacher;
            this.textIdentifier = textIdentifier;
            this.Dict.Add(textIdentifier, teacher);        
        }

        public Dictionary<string, Teacher> Dict
        {
            get
            {
                return this.dictionary;
            }

            set
            {
                this.dictionary.Add(this.textIdentifier, this.teacher);
            }
        }
    }
}
