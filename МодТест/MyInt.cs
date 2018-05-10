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
    }
}
