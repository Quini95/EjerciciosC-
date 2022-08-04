//Ejercicio 1

//Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada
//dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
/*
Console.WriteLine("Introduce tu nombre");
String nombre = Console.ReadLine();
Console.WriteLine("Introduce tu apellido");
String apellido = Console.ReadLine();
Console.WriteLine("Introduce tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar?");
String programar = Console.ReadLine();

Console.WriteLine("Te llamas " + nombre + " " + apellido + ", tienes " + edad + " años" + " y sabes programar?: " + programar);
*/
//Ejercicio 2

//Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

//Coche: puertas, ruedas, marca, ITV vigente

//Mesa: peso, largo, material, color

int puertas = 4;
int ruedas = 4;
String marca = "Ford";
Boolean itv = true;

double peso = 5.6d;
float largo = 180.50f;
String material = "Madera";

//Ejercicio 3

//Operadores Determina los operadores para verificar las siguientes condiciones:

//Un número es mayor o igual a 18

int num1 = 15;
Boolean esMayor = num1 >= 18;
Console.WriteLine(esMayor);


//Un char es ‘a’
char caracter = 'a';
Boolean caracterA = caracter == 'a';
Console.WriteLine(caracterA);

//Se cumplen dos conciones a la vez (ambas verdaderas)

Boolean doblecondicion = num1 >= 10 && num1 <= 20;

//Se cumple una de dos condiciones a la vez (una true y otra false)

Boolean doblecondicion2 = num1 >= 10 && num1 <= 14;



