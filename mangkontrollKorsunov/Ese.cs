namespace mangkontrollKorsunov
{
    class Ese : Uksus
    {
        private string nimetus;
        private int punktidearv;
        public Ese(string nimetus, int punktidearv)
        {
            this.nimetus = nimetus;
            this.punktidearv = punktidearv;
        }
        public int punktideArv()
        {
            return punktidearv;
        }
        public string Info()
        {
            return nimetus;
        }
    }
}