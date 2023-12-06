using System;

namespace platzi.Models
{
    internal class AntiHero : SuperHero
    {
        // base es el super de este lenguaje, entonces con base seteamos las props inherentes al padre
        public AntiHero(string name, string identidadSecreta, List<SuperPower> superPowers, bool flyer, string ciudad) : base(name, identidadSecreta, superPowers, flyer, ciudad)
        {
        }

        public string AntiHeroAction(string action)
        {
            return $"El antiheroe {NameAndSecretIdentity} ha realizado: {action}";
        }
    }
}

