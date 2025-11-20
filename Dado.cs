using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public  class Dado
    {
        public int nl;
        private Random rnd;
        

        public Dado():this(6)
        { }
        public Dado(int nf)
        {
            nl= nf;
            rnd = new Random();
        }
        public int Lancia()
        {
            return rnd.Next(1,nl+1);
        }
    }
    

}
