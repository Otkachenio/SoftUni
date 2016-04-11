namespace Problem3.GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Struct
            | AttributeTargets.Class
            | AttributeTargets.Interface
            | AttributeTargets.Enum
            | AttributeTargets.Method, AllowMultiple = false)]

    class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}