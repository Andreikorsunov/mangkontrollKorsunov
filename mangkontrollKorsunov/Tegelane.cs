using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mangkontrollKorsunov
{
    abstract class Tegelane : Uksus
    {
        private string nimi;
        private List<Ese> Asjad = new List<Ese>() { };
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public void LisaEse()
        {
            
        }
        
    }
}
