using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        //static void Main(string[] args)
        //{

        //    //Ejercicios 1:
        //    //Diseña un método esPar() que reciba como parámetro un entero y devuelva si ese número es par o no.
        //    //Utilízalo en un programa que lea un número por teclado y determine si es par o no.

        //    Console.WriteLine("introduzca un numero");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    esPar(num);
        //    Console.ReadLine();
        //}

        //public static void esPar(int numRecibido)
        //{
        //    if (numRecibido % 2 == 0)
        //    {
        //        Console.WriteLine(" Es Par");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Es Impar");
        //    }
        //}

        //*******************EJERCICIOS SENCILLOS*****************************

        //EJercicio 1:
        // Escribe una función que escriba “Hola” 3 veces.Llámala desde el programa principal.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Buenos Días");

        //    saludo();
        //    Console.ReadLine();
        //}
        //public static void saludo ()
        //{
        //    Console.WriteLine("Hola");
        //    Console.WriteLine("Hola");
        //    Console.WriteLine("Hola");
        //}


        //Ejercicios 2:
        //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro. 
        //Llámala desde el programa principal dos veces, primero con 5 y después con 3.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("¿Cuantas veces saludo?");
        //    int veces = Convert.ToInt32(Console.ReadLine());
        //    Saludo(veces);
        //    Console.ReadLine();
        //}

        //public static void Saludo(int numveces)
        //{
        //    for (int i = 0; i < numveces; i++)
        //    {
        //        Console.WriteLine("Hola");
        //    }
        //}

        //Ejercicio 3:

        //static void Main(string[] args)
        //{


        //Ejercicio 4:
        //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos.
        //En el programa principal, pide al usuario 2 números.Usa esos 2 números como parámetros de la función 
        //y después asigna el valor que devuelve la función a una tercera variable en el programa.
        //Finalmente, muestra el valor de la variable en la pantalla.

        //static void Main(string[] args)
        //{
        //    int num1, num2;

        //    Console.WriteLine("introduce un numero");
        //    num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("introduce otro numero");
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //    int resultado = suma1(num1, num2);
        //    Console.WriteLine("El resultado de la suma es: ");

        //}
        //public static int suma1(int numa, int numb)
        //{
        //    return numa + numb;
        //}


        //******************** EJERCICIOS NO SENCILLOS ******************************

        //Ejercicio 2:
        //Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo. 
        //Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área. 
        //Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla
        //Aquí te mostramos que necesita cada figura:
        //Circulo: (radio^2)*PI
        //Triangulo: (plano * altura) / 2
        //Cuadrado: lado* lado

        //static void Main(string[] args)
        //{
        //    double radio, plano, altura, lado;
        //    const int circulo = 1, cuadrado = 2, triangulo = 3;
        //    int eleccion;

        //    do
        //    {
        //        Console.WriteLine("introduzca la figura cuyo area quiere calcular: ");
        //        Console.WriteLine("1- circulo");
        //        Console.WriteLine("2- cuadrado");
        //        Console.WriteLine("3- triangulo");
        //        eleccion = Convert.ToInt32(Console.ReadLine());

        //        if (eleccion == 1)
        //        {
        //            Console.WriteLine("introduzca valor del radio");
        //            radio = Convert.ToInt32(Console.ReadLine());
        //            double resultadoCir = AreaCir(radio);
        //            Console.WriteLine("El area del circulo es: " + resultadoCir);
        //            Console.ReadLine();
        //        }

        //        else if (eleccion == 2)
        //        {
        //            Console.WriteLine("introduzca valor del lado");
        //            lado = Convert.ToInt32(Console.ReadLine());
        //            double resultadoCua = AreaCua(lado);
        //            Console.WriteLine("El area del cuadrado es: " + resultadoCua);
        //            Console.ReadLine();
        //        }

        //        else if (eleccion == 3)
        //        {
        //            Console.WriteLine("introduzca valor de la base");
        //            plano = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("introduzca valor de la altura");
        //            altura = Convert.ToInt32(Console.ReadLine());
        //            double resultadoTri = AreaTri(plano, altura);
        //            Console.WriteLine("El area del triangulo es: " + resultadoTri);
        //            Console.ReadLine();
        //        }
        //        else if (eleccion <= 0 || eleccion >= 4)
        //        {
        //            Console.WriteLine("Opcion Incorrecta, asigne una valida");
        //        }

        //    } while (eleccion != 3);

        //    Console.ReadLine();
        //}

        //const double pi = 3.1416;
        //public static double AreaCir(double numRad)
        //{
        //    return (Math.Pow(numRad, 2)) * pi;
        //}
        //public static double AreaCua(double numLado)
        //{
        //    return Math.Pow(numLado, 2);
        //}
        //public static double AreaTri(double numBas, double numAlt)
        //{
        //    return (numBas * numAlt) / 2;
        //}


        //Ejercicio 3:
        //Crea una aplicación que nos genere una cantidad de números enteros aleatorios que nosotros le pasaremos por teclado. 
        //Crea un método donde pasamos como parámetros entre que números queremos que los genere, podemos pedirlas por teclado 
        //antes de generar los números. Este método devolverá un número entero aleatorio. Muestra estos números por pantalla.

        //static void Main(string[] args)
        //{
        //    int num, max, min;
        //    Console.WriteLine("introduzca cantidad de numeros generados");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("introduzca el numero maximo del rango");
        //    max = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("introduzca el numero minimo del rango");
        //    min = Convert.ToInt32(Console.ReadLine());
        //    Generador(num, max, min);
            

        //    Console.ReadLine();
        //}
        //public static void Generador(int numTotal, int numMax, int numMin)
        //{
        //    Random genAlea = new Random();
        //    for (int i = 0; i < numTotal; i++)
        //    {
        //        int geneAle = genAlea.Next(numMin, numMax);
        //        Console.WriteLine("El numero generado es: " + geneAle);
        //    }
        //}

        //Ejercicio 4:
        // Crea una aplicación que nos calcule el factorial de un número pedido por teclado, lo realizara mediante un método 
        //al que le pasamos el número como parámetro. Para calcular el factorial, se multiplica los números anteriores hasta 
        //llegar a uno. Por ejemplo, si introducimos un 5, realizara esta operación 5*4*3*2*1=120.

        //static void Main(string[] args)
        //{
        //    int num;
        //    Console.WriteLine("introduzca un numero");
        //    num = Convert.ToInt32(Console.ReadLine());
        //    int resultado = Factorial(num);
        //    Console.WriteLine(" el factorial del numero es: " + resultado);
        //    Console.ReadLine();
        //}
        //public static int Factorial(int numa)
        //{
        //    for (int i = 0; i < numa; i++)
        //    {
        //        int producto = 1;
        //        return producto = producto * numa;
        //    }
        //}

    }
}
