namespace Problem1.Customer
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main(string[] args)
        {

            Customer pesho = new Customer(
                "Petar",
                "Ivanov",
                "Petrov",
                "1234567890",
                "Sofia, Golden st. ent. 6A",
                "0884565250",
                "pesho@dir.bg",
                new List<Payment>() { new Payment("Cosmo disk", 124.29m)},
                CustomerType.Diamond);

            Customer misho = new Customer(               
                "Mihail",
                "Ivanov",
                "Mihailov",
                "1023456789",
                "Pernik, Morava st. ent. 4",
                "0884565253",
                "misho@dir.bg",            
                new List<Payment>() { new Payment("Cosmo disk", 124.29m), new Payment("magnitni nakolenki", 45.68m) },
                CustomerType.Golden);

            Customer gosho = new Customer(               
                "Georgi",
                "Borisov",
                "Georgiev",
                "1203456789",
                "Divotino, 17st. ent. 5B",
                "0884565252",
                "goshko@dir.bg",               
                new List<Payment>() { new Payment("magnitni nakolenki", 45.68m) },
                CustomerType.Regular);

            Customer goshoCopy = gosho;
            gosho.FirstName = "Genka";
            Console.WriteLine(gosho);
            Console.WriteLine(goshoCopy);
            Console.WriteLine(goshoCopy == gosho);
            Console.WriteLine(gosho.Equals(goshoCopy));
            Console.WriteLine(Object.ReferenceEquals(gosho, goshoCopy));

            goshoCopy = (Customer)gosho.Clone();
            goshoCopy.FirstName = "Gosho";
            goshoCopy.Payments.Add(new Payment("soleti", 2.03m));
            Console.WriteLine(gosho);
            Console.WriteLine(goshoCopy);
            Console.WriteLine(goshoCopy == gosho);
            Console.WriteLine(gosho.Equals(goshoCopy));
            Console.WriteLine(Object.ReferenceEquals(gosho, goshoCopy));
        }
    }
}