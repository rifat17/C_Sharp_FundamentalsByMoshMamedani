using System;
using System.Collections.Generic;

namespace CSharpFUndamental.HttpCookieClass
{
    public class HttpCookie
    {
        public DateTime ExpireDate { get; set; }
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();


        public string this[string key]
        {
            get
            { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
