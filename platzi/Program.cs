using platzi.Models;

SuperPower volar = new SuperPower();
volar.Name = "Volar";
volar.Description = "Capacidad para volar y planear en el aire";
volar.Id = 1;
volar.Level = NivelPoder.NivelUno;

SuperPower superFuerza = new SuperPower();
superFuerza.Name = "Super fuerza";
superFuerza.Description = "Fuerza sobre humana";
superFuerza.Id = 2;
superFuerza.Level = NivelPoder.NivelTres;

/*
 Los arrays y las listas son similares pero los arrays son de tipo estatico y finito, mientras las listas pueden ser de cualquier longitud, en cuestiones
de optimizacion es mejor usar Arrays pero cuando no se sabe cuanta data estara almacenada y el tipo, es mejor usar una List aunque pese mas.
 */

List<SuperPower> supermanPowers = new List<SuperPower>();
supermanPowers.Add(volar);
supermanPowers.Add(superFuerza);
SuperHero superman = new SuperHero("Superman","Clark Kent",supermanPowers,true,"Metropolis");

string text=superman.UseSuperPower();
Console.WriteLine(text);

/*
 *********************************
     Tipos Registro y Struct
 *********************************

    Tipo   | Que supone | Tamaño | Orientacion
    CLASES: Referencia  | Grande | Valores y comportamientos
    ESTRUCTURA: Valor   | Peque  | Enfocado a Valores
    REGISTRO: Valor o Ref| Peque | Enfocado a valores inmutables


    Los Records parecen clases, pero los records permiten compararse con otros segun sus valores
    con las clases no podemos hacer esto porque class no toma el valor, toma la referencia.
 */