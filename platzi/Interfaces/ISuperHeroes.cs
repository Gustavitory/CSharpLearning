using System;
namespace platzi.Interfaces
{
	public interface ISuperHeroes
	{
		string Name { get; set; }
		int Id { get; set; }
		string IdentidadSecreta { get; set; }
	}
}
//C# permite implementar mas de una interfaz a una clase
//Por eso es mas usada que la extension de clases o herencia
//y solo se encarga de definir las props y los tipos de cada una de ellas
//para una clase
