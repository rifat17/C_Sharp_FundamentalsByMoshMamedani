﻿using System;
using CSharpFUndamental.Constructor;
using CSharpFUndamental.HttpCookieClass;
using CSharpFUndamental.Method;
using CSharpFUndamental.ObjectInitializer;

namespace CSharpFUndamental
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Constructor();

            //ObjectInitializer();

            //Method();

            //UseOutModifier();

            //Fields();

            //AccessModifier();

            //Properties();

            HttpCookieTest();
        }

        private static void HttpCookieTest()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Hasib";
            Console.WriteLine(cookie["name"]);
        }

        private static void Properties()
        {
            var person = new PropertyClasses.Person();
            person.Birthdate = new DateTime(2000, 1, 1);
            Console.WriteLine(person.Age);
        }

        private static void AccessModifier()
        {
            var person = new AccessModifier.Person();
            person.SetBirthdate(new DateTime(2000, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }

        private static void Fields()
        {
            var customer = new Field.Customer(1);
            customer.Orders.Add(new Field.Order());
            customer.Orders.Add(new Field.Order());
            customer.Orders.Add(new Field.Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }

        private static void UseOutModifier()
        {
            //int.Parse("asa");

            int number;
            var result = int.TryParse("asa", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }

        private static void Method()
        {
            //Signature of Method : 
            //1. Name
            //2. Number and Type of parameters
            UsePoints();

            UseCalculator();
        }

        private static void UseCalculator()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4 }));
        }

        private static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);

                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexception error occured.");
            }
        }

        private static void ObjectInitializer()
        {
            var person = new Person
            {
                Name = "test"
            };
        }

        private static void Constructor()
        {
            var customer = new Customer(1, "John");
            var order = new Order();

            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
