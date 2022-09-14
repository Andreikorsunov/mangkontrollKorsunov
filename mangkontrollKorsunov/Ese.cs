using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangkontrollKorsunov
{
    internal class Ese : Uksus
    {
        private string nimetus;
        private int punktidearv;
        public Ese(string nimetus, int punktidearv)
        {
            this.nimetus = nimetus;
            this.punktidearv = punktidearv;
        }
        public Ese(Ese ese)
        {
            this.nimetus = ese.nimetus;
            this.punktidearv = ese.punktidearv;
        }
        public override int punktideArv()
        {
            return punktidearv;
        }
        public override string Info()
        {
            return nimetus;
        }
    }
}
