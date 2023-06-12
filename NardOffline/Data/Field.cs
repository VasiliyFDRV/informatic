using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NardOffline
{
    class Field
    {
        public string color;
        public int qty;
        public Field()
        {
            color = "";
            qty = 0;
        }

        public Field(string clr, int qt)
        {
            color = clr;
            qty = qt;
        }
        public void Change(string clr, int qt)
        {
            color = clr;
            qty = qt;
        }
    }

}
