using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{


    public class Solution
    {
        public double EvalRPN(string[] tokens)
        {
            Stack<double> values = new Stack<double>();
            double a = 0;
            double b = 0;
            double y=0;
            var token1="";
            foreach (var token in tokens)
            {
                if (token == "+")
                {
                    a = values.Pop();
                    b = values.Pop();

                    values.Push(b + a);
                    continue;
                }

                if (token == "-")
                {
                    a = values.Pop();
                    b = values.Pop();

                    values.Push(b - a);
                    continue;
                }

                if (token == "*")
                {
                    a = values.Pop();
                    b = values.Pop();

                    values.Push(a * b);
                    continue;
                }

                if (token == "/")
                {
                    a = values.Pop();
                    b = values.Pop();

                    values.Push(b / a);
                    continue;
                }

                if(token[0]=='s')
                {
                    double sol = 0;
                   
                    for (int k = 3; k < token.Length; k++)
                        sol = (token[k] - '0') +10*sol;
                    double sol1 = (sol * (Math.PI)) / 180;
                        y = Math.Sin(sol1);
                     token1 = y.ToString();
                     values.Push(double.Parse(token1));
                }
                else if (token[0] == 'c' && token[1] == 'o' )
                {
                    double sol = 0;
                    
                    for (int k = 3; k < token.Length; k++)
                        sol = (token[k] - '0') + 10 * sol;
                    double sol1 = (sol * (Math.PI)) / 180;
                    y = Math.Cos(sol1);
                    token1 = y.ToString();
                    values.Push(double.Parse(token1));
                }
                else if (token[0] == 't')
                {
                    double sol = 0;
                    for (int k = 3; k < token.Length; k++)
                        sol = (token[k] - '0') + 10 * sol;
                    double sol1 = (sol * (Math.PI)) / 180;
                    y = Math.Tan(sol1);
                    token1 = y.ToString();
                    values.Push(double.Parse(token1));
                }
                else if (token[0] == 'c' && token[1] == 't')
                {
                    double sol = 0;
                    for (int k = 4; k < token.Length; k++)
                        sol = (token[k] - '0') + 10 * sol;
                    double sol1 = (sol * (Math.PI)) / 180;
                    y = Math.Sin(sol1);
                    double y1 = Math.Cos(sol1);
                    y1 /= y;
                    token1 = y1.ToString();
                    values.Push(double.Parse(token1));
                }
                else  if (token[0] == 'l' && token[1] == 'n')
                {
                    double sol = 0;
                    String aux = token.Substring(2);
                    sol = double.Parse(aux);
                    y = Math.Log(sol);
                    token1 = y.ToString();
                    values.Push(double.Parse(token1));
                }
                else if (token[0] == 'l' && token[1] == 'o')
                {
                    double sol = 0;
                    String aux = token.Substring(3);
                    sol = double.Parse(aux);
                    y = Math.Log(sol,10);
                    token1 = y.ToString();
                    values.Push(double.Parse(token1));
                }
                else  if (token[0] == 'r')
                {
                    double sol = 0;
                    String aux = token.Substring(3);
                    sol = double.Parse(aux);
                    y = Math.Sqrt(sol);
                    token1 = y.ToString();
                    values.Push(double.Parse(token1));
                }
               else if (token[0] == 'p')
                {
                    double sol = 0;
                    for (int k = 3; k < token.Length; k++)
                        sol = (token[k] - '0') + 10 * sol;
                    //    double sol1 = (sol * (Math.PI)) / 180;
                    y = Math.Pow(sol,2);
                    token1 = y.ToString();
                    values.Push(double.Parse(token1));
                }
                
                else values.Push(double.Parse(token));
            }

            return values.Peek();
        }
    }
    }

