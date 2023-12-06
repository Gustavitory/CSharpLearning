using System.Text;
using platzi.Interfaces;

namespace platzi.Models
{
    internal class SuperHero:SuperHuman, ISuperHeroes
    {
        public int Id { get; set; }
        //Encapsulamiento en Name
        private string _Name=""; // _Name es la propiedad y Name es como accedemos o manejamos la propiedad
        //public string Name { get { return _Name; } set { _Name = value.Trim(); } }

        public override string Name { get => _Name; set => _Name=value.Trim(); }
        // hagamos otra propiedad pero solo de lectura
        public string NameAndSecretIdentity
        {
            get
            {
                return $"{Name} ({IdentidadSecreta})";
            }
        }


        public string IdentidadSecreta { get; set; }
        public string Ciudad;
        public List<SuperPower> SuperPowers;
        public bool Flyer;

        private static int contadorId = 1;

        public SuperHero(string name, string identidadSecreta, List<SuperPower> superPowers, bool flyer, string ciudad="")
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
                sb.AppendLine($"{NameAndSecretIdentity} esta usando el super poder {item.Name}");
            }

            return sb.ToString();
        }


        //Metodo exigido por la clase abstracta de la que superhero es hijo
        public override string saveTheWorld()
        {
            return $"{NameAndSecretIdentity} ha salvado el mundo";
        }

        //aplicamos polimorfismo
        public override string saveEarth()
        {
            //return base.saveEarth();
            return $"{NameAndSecretIdentity} ha salvado la tierra";
        }
    }   
}


