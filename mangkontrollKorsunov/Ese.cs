using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangkontrollKorsunov
{
    abstract class Ese : Uksus
    {
        private string nimi;
        private int punktidearv;
        public Ese(string nimi, int punktidearv)
        {
            this.nimi = nimi;
            this.punktidearv = punktidearv;
        }
        public virtual int PunktideArv()
        {
            return punktidearv;
        }
        public override string Info()
        {
            return nimi;
        }
    }
}
