using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class fp
    {
        public string FP(string expr)
        {
            Stack<char> st = new Stack<char>(100);
            string polo = " ";
            bool ok = false; ;

            expr = '(' + expr + ')';
            for (int i = 0; i < expr.Length; i++)
            {
                while (expr[i] >= '0' && expr[i] <= '9' || expr[i] == ',' ||(expr[i]>='a'&&expr[i]<='z'))
                {
                    polo += expr[i];
                    i++;
                    ok = true;
                }
                if (ok == true) polo = polo + " ";
                ok = false;
                if (expr[i] == '(')
                    st.Push('(');
                if (expr[i] == ')')
                {
                    while (st.Peek() != '(')
                    {
                        polo += st.Peek();
                        polo += ' ';
                        st.Pop();

                    }
                    st.Pop();
                }
                if (expr[i] == '+' || expr[i] == '-')
                {


                    if (st.Count() == 0 || st.Peek() == '(')
                    {
                        st.Push(expr[i]);
                    }
                    else
                    {

                        polo += st.Peek();
                        polo += " ";
                        st.Pop();
                        i--;
                    }
                }
                if (expr[i] == '*' || expr[i] == '/')
                {

                    if (st.Count() == 0 || st.Peek() == ('(') || st.Peek() == '+' || st.Peek() == '-')
                    {
                        st.Push(expr[i]);
                    }
                    else
                    {
                        polo += " ";
                        polo += st.Peek();
                        st.Pop();
                        i--;
                    }
                }
            }
            return polo;

        }
        public string[] transform(string expr)
        {


            string[] vector1 = new string[100000];
            String aux1 = FP(expr);
            int i = 0;
            int k = 0;
            while (i < aux1.Length - 1)
            {
                if (aux1[i] == '+' || aux1[i] == '-' || aux1[i] == '*' || aux1[i] == '/')
                {
                    vector1[k] = char.ToString(aux1[i]);
                    k++;
                    i++;
                }
                else if (aux1[i] == ' ') i++;
                else
                {
                    string aux = "";
                    while (aux1[i] != '+' && aux1[i] != '-' && aux1[i] != '*' && aux1[i] != '/' && aux1[i] != ' ')
                    {
                        aux += aux1[i];
                        i++;
                    }

                    vector1[k] = aux;
                    k++;
                }
            }
            string[] finalvector = new string[k];
            for (int j = 0; j < k; j++)
                finalvector[j] = vector1[j];

            return finalvector;
        }
    }
}
