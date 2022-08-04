//Ejercicio 1 - While

//Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola.
//Es decir, un programa que presente para el 1:

//1 x 1 = 1
//1 x 2 = 2
//…
//1 x 10 = 10


int num;
int contador = 0;


Console.WriteLine("Introduce el numero a multiplicar");
num = Convert.ToInt32(Console.ReadLine());

while (contador <= 10)
{
    Console.WriteLine(num + " x " + contador + " = " + num * contador);
    contador++;
}

//Ejercicio 2 - Do while

//Escribe un programa que realice estos pasos:

//Reciba al menos un número por consola

//Determine si el número es positivo o negativo

//Presente un contador para cada tipo (positivo y negativo).


int contadorpositivos = 0;
int contadornegativos = 0;
int num1;



do
{
    Console.WriteLine("Introduce un numero");
    num1 = Convert.ToInt32(Console.ReadLine());

    if (num1 > 0)
    {
        Console.WriteLine("El numero introducido es positivo");
        contadorpositivos++;


    }
    else
    {
        Console.WriteLine("El numero introducido es negativo");
        contadornegativos++;
        Console.WriteLine("Contador de negativos = " + contadornegativos);
    }

    Console.WriteLine("Contador de positivos = " + contadorpositivos);
    Console.WriteLine("Contador de negativos = " + contadornegativos);

} while (contadorpositivos < 10 || contadornegativos < 10);


//Ejercicio 3 - For

//Escribe un programa que realice estos pasos:

//Reciba 3 datos: ancho, alto, relleno si o no

//Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas
//y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

//En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

int ancho;
int alto;
Boolean relleno;

Console.WriteLine("Introduzca el ancho");
ancho = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduzca el alto");
alto = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= ancho; i++)
{
        Console.Write("*");
    for (int j = 2; j <= alto; j++)
    {
        if (j == alto)
        {
            Console.WriteLine("*");
        }
        else
        {
            Console.Write("*");
        }
            
    }
   

}