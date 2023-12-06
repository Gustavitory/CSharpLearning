using System;
using platzi.Interfaces;
namespace platzi.Models
{
	public class ImprimirInfo
	{
		public void ImprimirSuperHeroe(ISuperHeroes superHeroes)
		{
			Console.WriteLine($"Id: {superHeroes.Id}\nNombre: {superHeroes.Name}\nIdentidad secreta: {superHeroes.IdentidadSecreta}");
		}
	}
}

