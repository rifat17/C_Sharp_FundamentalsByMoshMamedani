﻿using System;
namespace CSharpFUndamental.AccessModifier
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime date)
        {
            _birthdate = date;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

        //public DateTime Birthdate 
        //{
        //    get { return _birthdate; } 
        //    set { _birthdate = value;  }
        //}

        //public DateTime Birthdate { get; set; }
    }
}
