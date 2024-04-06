// See https://aka.ms/new-console-template for more information


string opcion = "";
do
{
    Console.WriteLine("");
    Console.WriteLine("----------------------------------------MENÚ-----------------------------------");
    Console.WriteLine("1.Determinar si un número ingresado por el usuario es positivo, negativo o cero.");
    Console.WriteLine("2.Imprimir un mensaje según el día de la semana ingresado por el usuario.");
    Console.WriteLine("3.Calcular la suma de los primeros 100 números naturales.");
    Console.WriteLine("4.Imprimir todos los números desde 1 hasta el número ingresado por el usuario.");
    Console.WriteLine("5.Calcular el área de un círculo utilizando el radio ingresado por el usuario.");
    Console.WriteLine("6.Mostrar los elementos de un arreglo unidimensional predefinido.");
    Console.WriteLine("7.Mostrar nombres de personas almacenados en una lista predefinida.");
    Console.WriteLine("8.Salir.");
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.WriteLine("Ingrese un número de acuerdo a lo que desea realizar, segun el menú:");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            ImprimirEsPositivoNegativocero();
            break;
        case "2":
            ImprimirMensajeSegunDia();
            break;
        case "3":
            ImprimirSumar100PrimerosNumerosNaturales();
            break;

        case "4":
            ListarNumeros();
            break;
        case "5":
            ImprimirCalcularAreaCirculo();
            break;

        case "6":
            MostrarElementoArray();
            break;
        case "7":
            ListarNombres();
            break;

        default:
            Console.WriteLine("");
            Console.WriteLine("El número ingresado no está dentro del menú");
            break;
    }

} while (opcion!="8");

// menu 1
string EsPositivoNegativoCero(int numero)
{
    string mensaje1="";
	if (numero==0)
	{
		mensaje1= "El número ingresado es 0";
	}
    if (numero >0)
    {
        mensaje1 = "El número ingresado es Positivo";
    }
    if(numero < 0)
    {
        mensaje1 = "El número ingresado es Negativo";
    }

    return mensaje1;
}
void ImprimirEsPositivoNegativocero()
{
    Console.WriteLine("");
    Console.WriteLine("Ingresa un número");
    int numeroIngresado = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("");
    Console.WriteLine(EsPositivoNegativoCero(numeroIngresado));
}

//menu 2
 string MensajeSegunDia(string dia)
{
    string mensaje = "";

    if (dia.ToUpper() == "LUNES")
    {
        mensaje = " Ten un buen Lunes";
    }
    if (dia.ToUpper() == "MARTES")
    {
        mensaje = " Ten un buen Martes";
    }
    if (dia.ToUpper() == "MIERCOLES")
    {
        mensaje = " Ten un buen Miércoles";
    }
    if (dia.ToUpper() == "JUEVES")
    {
        mensaje = " Ten un buen Jueves";
    }
    if (dia.ToUpper() == "VIERNES")
    {
        mensaje = " Ten un buen Viernes";
    }
    if (dia.ToUpper() == "SABADO")
    {
        mensaje = " Ten un buen Sábado";
    }
    if (dia.ToUpper() == "DOMINGO")
    {
        mensaje = " Ten un buen Domingo";
    }

    return mensaje;
}
void ImprimirMensajeSegunDia()
{
    Console.WriteLine("");
    Console.WriteLine("Ingresa un día de la semana:");
    string diaIngresado = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine(MensajeSegunDia(diaIngresado));
}

//menu 3
int Sumar100PrimerosNumerosNaturales()
{
    int suma = 0;
    for (int i = 1; i <101; i++)
    {
        suma= suma+i;
    }
    return suma;
}
void ImprimirSumar100PrimerosNumerosNaturales()
{
    Sumar100PrimerosNumerosNaturales();
    Console.WriteLine("");
    Console.WriteLine("La Suma de los 100 primeros numeros naturales es " + Sumar100PrimerosNumerosNaturales());
}

//menu 4
 void ListarNumeros()
{
    Console.WriteLine("");
    Console.WriteLine("Ingrese un número:");
    int numero= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    for (int i = 1; i < numero+1; i++)
    {
        Console.WriteLine(i);
    }
}

//menu 5
double CalcularAreaCirculo(int radio)
{
    double area = Math.PI*radio*radio;
    return Math.Round(area,2);
}

void ImprimirCalcularAreaCirculo()
{
    Console.WriteLine("");
    Console.WriteLine("Ingresa el radio del círculo");
    int radioIngresado = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    Console.Write("El área del círculo es " + CalcularAreaCirculo(radioIngresado));
}

//menu 6
void MostrarElementoArray()
{
    Console.WriteLine("");
    Console.WriteLine("Los elementos de mi array son:");
    int[] numeros = new int[5];
    numeros[0] = 2;
    numeros[1] = 4;
    numeros[2] = 6;
    numeros[3] = 10;
    numeros[4] = 20;
    int elemento = 0;
    for (int i = 0; i < 5; i++)
    {
        elemento = i + 1;
        Console.WriteLine("El elemento " + elemento + " es " + numeros[i]);
    }
}

//menu 7
void ListarNombres()
{
    List<string> nombres = new List<string>();
    nombres.Add("Pedro");
    nombres.Add("Juan");
    nombres.Add("Mateo");
    Console.WriteLine("");
    Console.WriteLine("Los nombres de mi Lista son :");
    foreach (var nombre in nombres) 
    {
        Console.WriteLine(nombre);
    }
} 