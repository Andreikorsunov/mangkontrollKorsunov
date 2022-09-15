namespace mangkontrollKorsunov
{
    class Tegelane : Uksus
    {
        private string nimi;
        private List<Ese> Esemed = new List<Ese>();
        public Tegelane(string nimi)
        {
            this.nimi = nimi;
            Esemed = new List<Ese>();
        }
        public void Info()
        {
            string Info = $"Nimi - {nimi}, Punktide Arv - {punktideArv()}";
            Console.WriteLine(Info);
        }
        public int punktideArv()
        {
            int sum = 0;
            foreach (Ese ese in Esemed)
            {
                sum += ese.punktideArv();
            }
            return sum;
        }
        public string EsemedOnValjanud()
        {
            foreach (Ese ese in Esemed)
            {
                Console.WriteLine(ese);
            }
            return EsemedOnValjanud();
        }
        public int LisaEse(int ese)
        {
            return ese;
        }

        string Uksus.Info()
        {
            throw new NotImplementedException();
        }
    }
}