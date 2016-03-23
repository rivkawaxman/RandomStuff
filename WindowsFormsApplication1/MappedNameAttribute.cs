using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MappedNameAttribute:Attribute
    {
        public string Name { get; set; }
    }
}
