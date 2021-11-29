using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class AuthorAttribute : Attribute
    {
        private string _name;
        public double _version;

        public AuthorAttribute(string name, double version)
        {
            _name = name;
            _version = version;
        }

        public double Version => _version;
        public string Name => _name;
    }
}
