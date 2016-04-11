namespace Problem1.Customer
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string iD;
        private string permanentAddress;
        private string mobilePhone;
        private string email;

        public Customer(string firstName, string middleName, string lastName, string iD,
            string permanentAddress, string mobilePhone, string email, List<Payment> payments,
            CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = iD;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Frist name cannot be empty!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Middle name cannot be empty!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Last name cannot be empty!");
                }

                this.lastName = value;
            }
        }

        public string ID
        {
            get
            {
                return this.iD;
            }

            set
            {
                if (value.Trim().Length != 10)
                {
                    throw new ArgumentException("ID have to consist 10 digits!");
                }

                this.iD = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            set
            {
                if (String.IsNullOrEmpty(value) || value == "")
                {
                    throw new ArgumentException("Permanent address cannot be empty!");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            set
            {
                if (value.Length < 10 || value.Length > 13)
                {
                    throw new ArgumentException("Mobile phone have to consist of 10 to 13 digits!");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value.Length < 5 || !(value.Contains("@")))
                {
                    throw new ArgumentException(
                        "E-mail have to be at least 5 chars long and contain @!");
                }

                this.email = value;
            }
        }

        public List<Payment> Payments { get; set; }

        public CustomerType Type { get; set; }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (param == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }

            if (!object.Equals(this.ID, customer.ID))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            string hashCode = this.FirstName + this.MiddleName + this.LastName + this.ID;
            return hashCode.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(String.Format("{0} {1} {2} - ID: {3} -> {4} client", 
                this.FirstName, this.MiddleName, this.LastName, this.ID, this.Type));
            result.AppendLine(String.Format("Permanent address: {0}", this.PermanentAddress));
            result.AppendLine(String.Format("Contact: e-mail - {0} , mobile phone - {1}",
                this.Email, this.MobilePhone));
            result.Append("Payments: ");
            result.AppendLine(String.Join(", ", this.Payments));

            return result.ToString();
        }

        public object Clone()
        {
            Customer newCustomer = this.MemberwiseClone() as Customer;

            newCustomer.Payments = new List<Payment>();
            foreach(var payment in Payments)
            {
                newCustomer.Payments.Add(payment);
            }

            return newCustomer;
        }

        public static bool operator == (Customer firstCustomer, Customer secondCustomer)
        {
            return Customer.Equals(firstCustomer, secondCustomer);
        }

        public static bool operator != (Customer firstCustomer, Customer secondCustomer)
        {
            return !(Customer.Equals(firstCustomer, secondCustomer));
        }

        public int CompareTo(Customer other)
        {
            string thisCustomer = String.Format("{0} {1} {2} - {3}",
                this.FirstName, this.MiddleName, this.LastName, this.ID);
            string otherCustomer = String.Format("{0} {1} {2} - {3}",
                other.FirstName, other.MiddleName, other.LastName, other.ID);

            return thisCustomer.CompareTo(otherCustomer);
        }
    }
}