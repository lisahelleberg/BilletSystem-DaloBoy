using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public class MC
    {
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            int total = 125;
            return total;
        }

        public string KøreTøj()
        {
            return "MC";
        }
    }
}
