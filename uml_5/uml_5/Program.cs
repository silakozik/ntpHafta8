using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_5
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }

        public void Update()
        {
            Console.WriteLine("Enter new transaction name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter new transaction date:");
            Date = Console.ReadLine();

            Console.WriteLine("Enter new transaction address:");
            Address = Console.ReadLine();

            Console.WriteLine("Transaction details updated successfully!");
        }
    }

    public class Reservation
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public string List { get; set; }

        public void Confirmation()
        {
            Console.WriteLine("Reservation confirmed!");
        }
    }

    public class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int Payment { get; set; }

        public void Update()
        {
            Console.WriteLine("Enter new customer name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter new costumer contact:");
            Contact = Console.ReadLine();

            Console.WriteLine("Enter new customer address:");
            Address = Console.ReadLine();

            Console.WriteLine("Customer details updated successfully!");
        }
    }

    public class RentingOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string ContactNumber { get; set; }

        private string username;
        private string password;
        public string Username
        {
            get { return username; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    username = value;
                else
                    throw new Exception("Username cannot be empty!");
            }
        }
        public string Password
        {
            get { return "******"; }
            set
            {
                if (value.Length >= 6) // Minimum şifre uzunluğu kontrolü
                    password = value;
                else
                    throw new Exception("Password must be at least 6 characters long!");
            }
        }

        public void VerifyAccount()
        {
            Console.WriteLine("Verifying account for owner: " + Name);
            Console.WriteLine("Account verified successfully!");
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public int Details { get; set; }
        public string OrderType { get; set; }

        public void ProcessDebit()
        {
            Console.WriteLine("Processing debit for car ID: " + Id);
            Console.WriteLine("Debit processed successfully!");
        }
    }

    public class Payment
    {
        public int Id { get; set; }
        public int CardNumber { get; set; }
        public string Amount { get; set; }

        public void Add()
        {
            Console.WriteLine("Enter card number:");
            CardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter payment amount:");
            Amount = Console.ReadLine();

            Console.WriteLine("Payment added successfully!");
        }

        public void Update()
        {
            Console.WriteLine("Enter new card number:");
            CardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new payment amount:");
            Amount = Console.ReadLine();

            Console.WriteLine("Payment details updated successfully!");
        }
    }

    public class Rentals
    {
        public int Id { get; set; }
        public string Names { get; set; }
        public string Price { get; set; }

        public void Add()
        {
            Console.WriteLine("Enter rental name:");
            Names = Console.ReadLine();

            Console.WriteLine("Enter rental price:");
            Price = Console.ReadLine();

            Console.WriteLine("Rental added successfully!");
        }

        public void Update()
        {
            Console.WriteLine("Enter new rental name:");
            Names = Console.ReadLine();

            Console.WriteLine("Enter new rental price:");
            Price = Console.ReadLine();

            Console.WriteLine("Rental details updated successfully!");
        }
    }
}

Customer customer = new Customer();
Transaction transaction = new Transaction();

Reservation reservation = new Reservation();
customer.Id = reservation.Id;

Payment payment = new Payment();
customer.Payment = payment.Id;
