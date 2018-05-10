using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МодТест
{
    public class MyInt
    {
        public string Value = "";

        //Конструкторы
        public MyInt()
        {
            Value = "";
        }
        public MyInt(int lolqop)
        {
            Value = ToStr(lolqop);

        }
        public MyInt(string lolqop)
        {
            Value = lolqop;
        }
        public MyInt(int[] pop)
        {
            for (int i = 0; i < pop.Length; i++)
            {
                if (i == 0)
                {
                    if (pop[i] == 1) Value = "-";
                    else if (pop[i] == 0) Value = "";
                }
                else
                {
                    Value = Value + pop[i];
                }
            }
        }

        public string ToStr(int val)
        {
            bool isMin = false;
            if (val < 0)
            {
                isMin = true;
                val = -val;
            }


            string result = "";

            long div = 10;
            long ost = 0;
            long dep = val;

            for (int i = 0; dep > 0; i++)
            {
                ost = dep % div;
                result = ost + result;
                dep = dep / div;

            }

            if (isMin) result = "-" + result;
            return result;

        }
        public MyInt abs()
        {
            if (Value[0] == '-') Value = Value.Substring(1);
            return new MyInt(Value);
        }
        public MyInt Max(MyInt other)
        {
            string A = Value;
            string B = other.Value;
            int Az = 0;
            int Bz = 0;

            if (A[0] == '-')
            {
                Az = 1;
                A = A.Substring(1);
            }
            if (B[0] == '-')
            {
                Bz = 1;
                B = B.Substring(1);
            }

            if (Az == 0 && Bz == 1) return this;
            else if (Az == 1 && Bz == 0) return other;
            else
            {
                if (A.Length > B.Length) return this;
                else if (B.Length > A.Length) return other;
                else
                {
                    bool isAmax = true;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (int.Parse(A[i].ToString()) > int.Parse(B[i].ToString())) break;
                        else if (int.Parse(A[i].ToString()) < int.Parse(B[i].ToString()))
                        {
                            isAmax = false;
                            break;
                        }
                    }

                    if (isAmax) return this;
                    else return other;
                }
            }

        }
    }
}
