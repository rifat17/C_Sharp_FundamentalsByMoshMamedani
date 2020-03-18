using System;
namespace CSharpFUndamental.PropertyClasses
{
    public class Person
    {
        //public Person(DateTime birthdate )
        //{
        //    Birthdate = birthdate;
        //}
        public DateTime Birthdate { get; set; }
        //public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                int years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
