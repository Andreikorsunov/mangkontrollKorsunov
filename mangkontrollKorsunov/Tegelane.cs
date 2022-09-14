namespace mangkontrollKorsunov
{
    abstract class Tegelane : Uksus
    {
        private string nimi;
        private List<Ese> Esemed = new List<Ese>() {  };
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
        }
        public Tegelane(Tegelane tegelane)
        {
            this.nimi = tegelane.nimi;
        }
        public void LisaEse()
        {
            
        }
        /*public virtual int PunktideArv()
        {
            return punktidearv;
        }
        var lines = File.ReadLines("esemed.txt");
 
            foreach (var line in lines)
            {
                var tokens = line.Split(':');
 
                Console.WriteLine($"{tokens[0]} {tokens[1]} {tokens[2]}");
            }*/
    }
}