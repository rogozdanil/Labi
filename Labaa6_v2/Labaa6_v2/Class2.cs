using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa6_v2
{
    // Класс атрибута
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    class Atr : Attribute
    {
        public Atr() { }
        public Atr(string str) { name = str; }
        public string name { get; set; }
    }
}
