namespace platzi.Models
{
	public abstract class SuperHuman
	{
		public abstract string Name { get; set; }
		public abstract string saveTheWorld();

		//Tambien puedo crear metodos no abstractos
		// virtual es como override pero la implementacion por el hijo no es obligatoria
		public virtual string saveEarth() => $"{Name} saved the earth";
	}
}

/* Cree un metodo abstracto sin logica, dentro de una clase abstracta, las clases que sean hijas de esta clase abstracta tendran la obligacion de tener un metodo
 que se llame "saveTheWorl" y tendran que usar la palabra reservada override para poder reescribirlo*/