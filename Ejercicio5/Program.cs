//Ejercicio 1 - If

//Escribe un programa que:

//Pida datos a un cliente: Nombre, email, cupón
//Determine si un cliente tiene un cupon descuento
//Muestre un precio rebajado en función del descuento
//Muestre el precio de un producto sin descuento si no hay cupón

String nombre; 
String email;
Boolean cupon;
int precio;
const int descuento = 3;

Console.WriteLine("Nombre");
nombre = Console.ReadLine();

if (nombre == "Fran")
{
    cupon = true;
} else if (nombre == "Manuel")
{
    cupon = true;
}
else
{
    cupon = false;
}

Console.WriteLine("Email");
email = Console.ReadLine();
Console.WriteLine("Introduzca el precio del producto");
precio = Convert.ToInt32(Console.ReadLine());

if (cupon == true)
{
    Console.WriteLine("Usted dispone de cupon de descuento, se le aplicará un descuento de " + descuento +
        "€ a su artículo.\nPrecio total: " + (precio - descuento) + "€");
}
else
{
    Console.WriteLine("Precio del artículo: " + precio + "€");
}


//Ejercicio 2 - Switch

//Haz una lista de lenguajes de programación, por ejemplo: C#, Java, C++. Presenta la lista en consola
//y pide que el usuario seleccione el lenguaje mediante 1, 2, 3 o a, b, c. Presenta el resultado en consola.

//Nota: puedes añadir al resultado el “Hola, mundo” para el caso de C#.


String[] lista = { "C#", "Java", "C++" };
int opcion;

Console.WriteLine("Elija lenguaje: (1, 2 ó 3)");
foreach (String lenguaje in lista)
{
    Console.WriteLine(lenguaje + " ");
}

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Usted ha elegido C#");
        break;
    case 2:
        Console.WriteLine("Usted ha elegido Java");
        break;
    case 3:
        Console.WriteLine("Usted ha elegido C++");
        break;
    default:
        Console.WriteLine("Usted ha introducido un parñametro erroneo");
        break;


}