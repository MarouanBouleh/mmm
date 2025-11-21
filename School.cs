using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class School
    {
        public string Code;
        public string Name;
        public string Tipo;
        public string City;
        public bool Public;
        public double Longit;
        public double Latit;
        
        public School( string c,string n,string t,string cy, bool p,double lt,double lg)
        {
            Code = c;Name = n;Tipo = c; City=t;Public = p; Longit=lg; Latit=lt;
        }
        public override string ToString() 
        {
          return Code.PadLeft(15)+Name.PadLeft(15);
        }
    }

}
