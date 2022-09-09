using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mangkontrollKorsunov.Ese;

namespace mangkontrollKorsunov
{
    abstract class Tegelane : Uksus
    {
        private string nimi;
        private List<Ese> ese = new List<Ese>() { };
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public void LisaEse()
        {
            
        }
        /*            var lines = File.ReadLines("test.txt");
 
            foreach (var line in lines)
            {
                var tokens = line.Split(':');
 
                Console.WriteLine($"{tokens[0]} {tokens[1]} {tokens[2]}");
            }*/
    }
}
