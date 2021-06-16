using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Hexa:Transformari
    {
        string x;
        public Hexa(string x){this.x=x;}
        public override string TR()
        {
            int z1 = int.Parse(x);
            string d = "";
            while (z1 > 0)
            {

                if (z1%16 >= 10)
                
                    switch (z1 % 16)
                    {
                        case 15:
                            {
                                d = "F" + d;
                                break;
                            }
                        case 14:
                            {
                                d = "E" + d;
                                break;
                            }
                        case 13:
                            {
                                d = "D" + d;
                                break;
                            }
                        case 12:
                            {
                                d = "C" + d;
                                break;
                            }
                        case 11:
                            {
                                d = "B" + d;
                                break;
                            }
                        case 10:
                            {
                                d = "A" + d;
                                break;
                            }
                    


                   
                }

                else
                    d = z1 % 16 + d;
                    z1 = z1 / 16;

                

            }

                return d;
            
        }
    }
}
