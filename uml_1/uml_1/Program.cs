using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_1
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public void PurchaseParkingPass()
        {
            Console.WriteLine($"{Name} purchased a parking pass.");
        }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Street) && !string.IsNullOrEmpty(City);
        }

        public string OutputAsLabel()
        {
            return $"{Street}, {City}, {State}, {PostalCode}, {Country}";
        }
    }

    public class Student : Person
    {
        public int StudentNumber { get; set; }
        public int AverageMark { get; set; }

        public bool IsEligibleToEnroll(string course)
        {
            return AverageMark >= 50;
        }

        public int GetSeminarsTaken()
        {
            return 5;
        }
    }

    public class Professor : Person
    {
        public int Salary { get; set; }
        protected int StaffNumber { get; set; }
        public int YearsOfService { get; set; }
        public int NumberOfClasses { get; set; }

        public void Supervise (Student student)
        {
            Console.WriteLine($"Professor {Name} is supervising Student {student.Name}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Street = "123 Main St",
                City = "Istanbul",
                State = "TR",
                PostalCode = 34000,
                Country = "Turkey"
            };

            if (address.Validate())
            {
                Console.WriteLine("Address is valid: " + address.OutputAsLabel());
            }

            Student student = new Student
            {
                Name = "Ali",
                PhoneNumber = "555-1234",
                EmailAddress = "ali@example.com",
                StudentNumber = 101,
                AverageMark = 85
            };

            Professor professor = new Professor
            {
                Name = "Dr. Ahmet",
                PhoneNumber = "555-5678",
                EmailAddress = "ahmet@example.com",
                Salary = 75000,
                YearsOfService = 10,
                NumberOfClasses = 3
            };

            professor.Supervise(student);
            Console.WriteLine($"Student {student.Name} is eligible to enroll: {student.IsEligibleToEnroll("Math")}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
    }
