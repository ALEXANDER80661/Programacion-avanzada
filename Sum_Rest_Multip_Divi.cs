using System;

double num_1;
double num_2;

Console.WriteLine("-----Calculadora basica-----");
Console.WriteLine("Ingresa un numero");
num_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingresa el segundo numero:");
num_2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("-----RESULTADOS-----");

Console.WriteLine("1.Suma");
Console.WriteLine("2.Resta");
Console.WriteLine("3.Multiplicacion");
Console.WriteLine("4.Division");

int opc = Convert.ToInt32(Console.ReadLine());
switch (opc)
{
    case 1:
        Console.WriteLine($"El resultado de la suma es:,{num_1 + num_2}");
        break;
    case 2:
        Console.WriteLine($"El resultado de la resta es:,{num_1 - num_2}");
        break;
    case 3:
        Console.WriteLine($"El resultado de la multiplicacion es:,{num_1 * num_2}");
        break;

    case 4:
        if (num_2 != 0)
        {
            Console.WriteLine($"El resultado de la division es:,{num_1 / num_2}");
        }
        else
        {
            Console.WriteLine("Division: No es posible dividir entre cero.");
        }
        break;
}


