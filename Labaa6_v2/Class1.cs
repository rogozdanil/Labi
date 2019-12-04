using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa6_v2
{
    public class Test
    {
        public Test() { }
        public Test(int x, string s) { i = x; str = s; }
        public Test(int x) { i = x; }
        public int i;
        public string str;
        public int sq (int x) { return x * x; }        
        [Atr("Описание свойства pr1")]
        public int pr1 { get; set; }
        [Atr("Описание свойства pr2")]
        public string pr2 { get; set; }       
    }
}
