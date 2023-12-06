namespace platzi.Models
{
    internal class SuperPower
    {
        public int Id;
        public string Name="";
        public string Description="";
        public NivelPoder Level;
    }

    enum NivelPoder
    {
        NivelUno, NivelDos, NivelTres
    }
}

