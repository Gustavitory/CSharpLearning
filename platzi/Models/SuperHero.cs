using System;
using System.Text;

namespace platzi.Models
{
    internal class SuperHero
    {
        public int Id;
        public string Name;
        public string IdentidadSecreta;
        public string Ciudad;
        public List<SuperPower> SuperPowers;
        public bool Flyer;

        private static int contadorId = 1;

        public SuperHero(string name, string identidadSecreta, List<SuperPower> superPowers, bool flyer, string ciudad)
        {
            Id = contadorId++;
            Name = name;
            IdentidadSecreta = identidadSecreta;
            SuperPowers = superPowers;
            Flyer = flyer;
            Ciudad = ciudad;
        }

        public string UseSuperPower()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPowers)
            {
                sb.AppendLine($"{Name} esta usando el super poder {item.Name}");
            }

            return sb.ToString();
        }
    }
}

