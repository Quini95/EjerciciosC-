// Ejercicio 1
//Escribe un programa que reciba tu nombre y lo escriba por consola.

Console.WriteLine("Introduce tu nombre");
String nombre = Console.ReadLine();
Console.WriteLine("Hola " + nombre + "!");

//Ejercicio 2
//Escribe un programa que tome la hora y la escriba por pantalla.

string datetime = DateTime.Now.ToString("hh:mm:ss");
Console.WriteLine("Son las " + datetime);
