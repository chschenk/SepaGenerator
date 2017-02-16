using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christopher.Schenk.SepaBeitragsGenerator
{
    class Column
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
