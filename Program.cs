/*
1. 	Realiza un cuadro comparativo explicando las diferencias
y similitudes entre la herencia y polimorfismo.

2. 	Realiza una breve explicación diciendo que son los atributos, 
los métodos y las clases. De un ejemplo clásico que explique todo.

3. 	Cual es la diferencia entre la sobre carga de métodos y 
la sobrecarga de constructores. 


1R:
Herencia                    // Polimorfismo

Ambas parten de una clase principal e influyen en el comportamiento de subclases
La herencia permite heredar de una clase padre a clases hijas//          El polimorfimo como su nombre lo dice le permite
metodos y atributos, que pueden variar dependiendo de la necesidad//     a un metodo comportarse de forma diferente dependiendo
que tenga la clase hija                                                  la clase donde se encuentre almacenado


2R:

Un atributo: es un espacio reservado en la memoria (Dentro de una clase) al cual le almacenamos un tipo de dato,
un nombre y sus modificadores de acceso según su nivel(public, protected, private)  

Un metodo: es un espacio reservado en la memoria,(Dentro de una clase) el cual dentro de su bloque de código tiene una funcionalidad,
los metodos comienzan por MAYUS, y tienen un () lo que significa un paso de parametros, este puede ir vacio y pedir datos dependiendo
de su funcionalidad

Una clase: Las clases son elementos de la POO que sirven como plantillas al momento de hacer un modelado del mundo real, estas están
compuestas por atributos y metodos. 

Ejemplo de todo lo anterior:

public class CalculadoraBasica
{
    public double Numero1 { set; get; } //Aquí podemos apreciar 2 atributos con sus caracteristicas
    public double Numero2 { set; get; }
    public double Numero3 { set; get; }
    public CalculadoraBasica(double numero1, double numero2) //Su Contructor
    {
        Numero1 = numero1;
        Numero2 = numero2;
    }
    public CalculadoraBasica() // Un Contructor sobrecargado, tiene el mismo nombre del anterior
                                                                             // solo que que recibe un parametro más                                   
    {

    }
    public  void Sumar() //Aqui tenemos un metodo con un paso de parametros vacio, un nivel de privacidad y una funcion dentro de su codigo 
    {
        Console.WriteLine($"La suma es: {Numero1 + Numero2}");
    }

    public void Sumar(double numero1, double numero2,double numero3) //Este seria el metodo de Sumar sobrecargado aceptando un paso de parametros cosa que
    {                                                   // no realizaba el primero

    }
}

*/
using ConsoleApp1;
using System.Reflection.Metadata.Ecma335;


public class Program
{
    public static void Main(string[] args)
    {
        
        Vuelo vuelo = new Vuelo(123, "Ciudad A", "Ciudad B", DateTime.Now, DateTime.Now.AddHours(2), 240, 200.0);

        vuelo.ReservarAsiento();

        Console.WriteLine(vuelo.ToString());


    }
}




