
/*Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje,
usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad,
sabe programar, etc.*/

Console.WriteLine(" Ingrese su nombre:");
 string nombre = Console.ReadLine();

Console.WriteLine(" Ingrese su apellido:");
string apellido = Console.ReadLine();

Console.WriteLine(" Ingrese su edad:");
int edad = Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine("Sabe programar?");
string programar = Console.ReadLine();


Console.WriteLine(" Nombre:"+nombre);
Console.WriteLine(" Apellido:" + apellido);
Console.WriteLine(" Edad:" + edad);
Console.WriteLine(" Sabe programar?:" + programar);

/*Ejercicio 2
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del 
ejercicio es almacenar los datos en los tipos más adecuados.*/

//Coche
int puertas = 4;
int ruedas = 5;
string marca = "Chevrolet";
string ITV = "Vigente";

//Mesa
float peso = 20.5f;
float largo = 1.20f;
string material = "Pino";
string color = "Marron";

Console.WriteLine(" ---COCHE---");
Console.WriteLine(" Puertas:" + puertas);
Console.WriteLine(" Ruedas:" + ruedas);
Console.WriteLine(" Marca:" + marca);
Console.WriteLine(" ITV:" + ITV);

Console.WriteLine(" ---MESA---");
Console.WriteLine(" Peso:" + peso);
Console.WriteLine(" Largo:" + largo);
Console.WriteLine(" Material:" + material);
Console.WriteLine(" Color:" + color);

/*

Ejercicio 3
Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del 
ejercicio es almacenar los datos en los tipos más adecuados.

*/

int numero = 23;
int x = 18;
Console.WriteLine(numero > x);// devuelve true, ya que 23 es mayor que 18.

char c = 'c';
Console.WriteLine(c=='C');// devuelve true.

int num1 = 10;
int num2 = 20;
int num3= 30;

Console.WriteLine(num1<num2 && num3 > num2);// devuelve true.

int num4 = 10;
int num5 = 20;
int num6 = 30;

Console.WriteLine(num4 < num5 || num5 > num6);// devuelve true y false.