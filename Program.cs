using System;

namespace c_sharp_odev_class1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.firstName = "John";
            employee1.lastName = "Doe";
            employee1.number = 10001;
            employee1.deparment = "IT";

            employee1.PrintEmployeeInformation();


            Console.WriteLine("");

            Employee employee2 = new Employee();
            employee2.firstName = "Bilbo";
            employee2.lastName = "Baggins";
            employee2.number = 123456;
            employee2.deparment = "HR";

            employee2.PrintEmployeeInformation();


        }
    }



    class Employee
    {
        public string firstName;
        public string lastName;
        public int number;
        public string deparment;

        public void PrintEmployeeInformation()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("Department: {0}", deparment);
        }

    }




}
