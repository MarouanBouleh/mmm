using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{    //CALCOLO VOLUME 
    public class Pacco
     {
        public double bas;
        public double alt;
        public double prof;
        public int Num;
        //costruttore 
        public Pacco(double b,double a,double p,int n) 
        { 
          bas= b; alt= a; prof= p; Num = n;
        }
        public override string ToString()
        {
            return Num+"\tb:"+bas+"\th:"+alt+"\tp:"+prof;
        }
        public double Volume()
        {
            return bas*alt*prof;
        }
    }
}
