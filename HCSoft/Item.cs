using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCSoft.Util
{
    public class Item
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public Item(string name, string value)
        {
            Name = name; Value = value;
        }
       
    }
}
