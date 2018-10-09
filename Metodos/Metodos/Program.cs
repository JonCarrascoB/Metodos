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
        //    int resultado = SacarFactor(num);
        //    Console.WriteLine(" el factorial del numero es: " + resultado);
        //    Console.ReadLine();
        //}
        //public static int SacarFactor(int numa)
        //{
        //    int producto = 1;
        //    for (int i = numa; i > 0; i--)
        //    {
        //    producto = producto * i;
        //    }
        //    return producto;
        //}


        //Ejercicio 5:
        //Crea una aplicación que nos cuente el número de cifras de un número entero positivo (hay que controlarlo) pedido por teclado.
        //Crea un método que realice esta acción, pasando el número por parámetro, devolverá el número de cifras.

        //static void Main(string[] args)
        //{
        //    int number;
        //    Console.WriteLine("introduce un numero entero");
        //    number = Convert.ToInt32(Console.ReadLine());
        //    if (number >= 0)
        //    {
        //        int sumaDig = CuentaCif(number);
        //        Console.WriteLine("La suma de los digitos es: " + sumaDig);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Numero incorrecto, introduzca otro");
        //    }
        //    Console.ReadLine();
        //}
        //public static int CuentaCif(int digit)
        //{

        //}

        //Ejercicio 6:
        //Crea un aplicación que nos convierta una cantidad de euros introducida por teclado a otra moneda, estas pueden ser a dolares,
        //yenes o libras. El método tendrá como parámetros, la cantidad de euros y la moneda a pasar que sera una cadena,
        //este no devolverá ningún valor, mostrara un mensaje indicando el cambio (void).
        //El cambio de divisas son:
        //0.86 libras es un 1 €
        //1.28611 $ es un 1 €
        //129.852 yenes es un 1 €

        //static void Main(string[] args)
        //{
        //Console.Write("introduzca la cantidad de Euros a convertir");
        //int coin = Convert.ToInt32(Console.ReadLine());
        //Console.Write("introduzca la moneda a convertir");
        //int coinValue = Transfer(
        //}


        //Ejercicio 9:
        //Método es_perfecto que determine si un número es o no perfecto. A este método se le pasa un número y devuelve: 
        //Verdadero: si el número es perfecto
        //Falso: si no es perfecto
        //Un número es perfecto si la suma de sus divisores excepto él, es igual al propio número.Ejemplo: 
        //6=1+2+3 es perfecto
        //Utilízalo en  un programa que pida  por teclado  números hasta que se teclee un  0  e indique  los siguientes resultados: 
        //Cantidad de números pares
        //Cantidad de números perfectos
        //Cantidad de múltiplos de 5

        static void Main(string[] args)
        {
            int numAlm = 1;
            int numPar = 0;
            int numMult = 0;
            while (numAlm != 0)
            {
                Console.WriteLine("introduzca su numero, por favor");
                numAlm = Convert.ToInt32(Console.ReadLine());

                if ((numAlm % 2) == 0)
                {
                    numPar++;
                }
                else if ((numAlm % 5) ==0)
                {
                    numMult++;
                }

                int numPerf = EsPerfecto(numAlm);
               




            }

            Console.WriteLine("Hay " + numPar + " numeros pares");
            Console.WriteLine("Hay " + numPerf + " numeros perfectos");
            Console.WriteLine("Hay " + numMult + " multiplos de 5");


            Console.ReadLine();
        }
        
        public static int EsPerfecto(int introAlm)
        {
            //int div = 0;
            for (int i=introAlm; i>0; i--)
            {
                if (introAlm%i ==0)
                {
                    int [] divArr =
                }
            }

        }
        


            //Ejercicio 10:
            //Diseña  un  método  pedirMes().  Solicita  un  número  de  mes  y  valida  que  se  trata  de  un número de mes correcto.
            //Devuelve dicho número de mes. 
            //Diseña un método pedirAnio(). Recibe como parámetros los límites entre los que debe de estar el año que se debe solicitar
            //por teclado. Devuelve el año entre dichos límites.
            //Diseña un método pedirDia(). Solicita un número de día por teclado, y dado un mes y un año válidos 
            //recibidos por  parámetro, devuelve un  día correcto.  (Nota:  puede llamar  al método esBisiesto)
            //Crea un nuevo método mostrarSiguienteDia() que recibe un día, un mes y un año válido (estos tres datos forman la fecha actual) 
            //y muestra en pantalla 2 fechas: la actual y la del día siguiente, a calcular a partir del día actual.
            //Pruébalo en  un programa  que pida  al usuario  una fecha(pedirDia(), pedirMes(), pedirAnio()) 
            //y muestre la fecha del día siguiente.
            //Ejemplo:  
            //Fecha actual: 31/12/2011 
            //Día siguiente: 1/1/2012 

        //    static void Main(string[] args)
        //{
        //    Console.WriteLine("introduzca numero de mes");
        //    int mes = Convert.ToInt32(Console.ReadLine());
        //    int valorMes = PedirMes(mes);
        //    Console.WriteLine("El mes es el " + valorMes);
        //    Console.WriteLine("introduzca año limite inferior");
        //    int annoMin = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Introduzca año limite superior");
        //    int annoMax = Convert.ToInt32(Console.ReadLine());

        //    if (annoMin > annoMax)
        //    {
        //        Console.WriteLine("Error, su limite minimo es superior al maximo, se le modifica al modo correcto");
        //        int cambio = annoMin;
        //        annoMin = annoMax;
        //        annoMax = cambio;
        //    }
        //    int Anno = PedirAnno(annoMin, annoMax);
        //    Console.WriteLine("Su año es: " + Anno);

        //    Console.WriteLine("Introduzca el numero del día");
        //    int dia = Convert.ToInt32(Console.ReadLine());

        //    int diaCorrecto = PedirDia(dia, valorMes, Anno);
        //    Console.WriteLine("Fecha Actual es: " + diaCorrecto + "/" + valorMes + "/" + Anno);

        //    if (diaCorrecto<28)
        //    {
        //        Console.WriteLine("Fecha dia siguiente es: " + (diaCorrecto + 1) + "/" + valorMes + "/" + Anno);
        //    }
        //    else if(diaCorrecto==29 && valorMes==2)
        //    {
        //        Console.WriteLine("Fecha dia siguiente es: 01"  + "/" + (valorMes +1) + "/" + Anno);
        //    }
        //    else if(valorMes==4 || valorMes == 6 || valorMes == 9 || valorMes == 11)
        //    {
        //        Console.WriteLine("Fecha dia siguiente es: 01" + "/" + (valorMes + 1) + "/" + Anno);
        //    }
        //    else if(valorMes == 1 || valorMes == 3 || valorMes == 5 || valorMes == 7 || valorMes == 8 || valorMes == 10)
        //    {
        //        Console.WriteLine("Fecha dia siguiente es: 01" + "/" + (valorMes + 1) + "/" + Anno);
        //    }
        //    else if(valorMes==12)
        //    {
        //        Console.WriteLine("Fecha dia siguiente es: 01" + "/" + "01" + "/" + (Anno+1));
        //    }
        //    Console.ReadLine();

        //}
        //public static int PedirMes(int introMes)
        //{
        //    while (introMes <= 0 || introMes > 12)
        //    {
        //        Console.WriteLine("Error, inserte un numero de mes correcto");
        //        introMes = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return introMes;
        //}
        //public static int PedirAnno(int minAnno, int maxAnno)
        //{
        //    Random rndm = new Random();
        //    int annoRndm = rndm.Next(minAnno, maxAnno + 1);
        //    return annoRndm;
        //}
        //public static int PedirDia(int introDia, int introMes, int introAnno)
        //{
        //    bool leapYear = DateTime.IsLeapYear(introAnno);
        //    int[] mesesArr = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //La posición del mes es 1 menos que la del mes real

        //    if (leapYear)
        //    {
        //        mesesArr[1] = 29;
        //    }

        //    while (introDia > mesesArr[introMes - 1] || introMes <= 0)
        //    {
        //        Console.WriteLine("Su día no corresponde a un día real del mes definido: " + introMes);
        //        Console.WriteLine("Inserte un nuevo día correcto, por favor");
        //        introDia = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return introDia;
        //}
       
    }
}

