using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SampleClass
    {
        [AuthorAttribute(name: "ID", version: 2.0)]
        public decimal Id { get; set; }
        [AuthorAttribute(name: "NOME", version: 3.5)]
        public string Nome { get; set; }
    }
}
