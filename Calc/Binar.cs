using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Binar:Transformari

    {
        string p;
        public Binar(string p){this.p=p;}
        public override string TR()
        {
            int z1 = int.Parse(p);
            string d = "";
            while(z1>0)
            {
                d = z1 % 2 + d;
                z1 = z1 / 2;
            }

            return d;
        }
    
   
}
}
