using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib
{
    public abstract class BaseBil
    {
        public string NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public abstract int Pris();
        public abstract string KøreTøj();

        public string nummerpladeLimit()
        {
            string nummerplade = this.NummerPlade;
            if (nummerplade.Length > 7)
            {
                throw new ArgumentException("Du har en for lang nummerplade, Retard.");
            }
            return nummerplade;
        }
    }
}
