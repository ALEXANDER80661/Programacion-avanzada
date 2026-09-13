using System;

Console.WriteLine("--- CALCULADORA ---");
Console.WriteLine("1. Cuadrado");
Console.WriteLine("2. Circulo");
Console.WriteLine("3. Rombo");
Console.WriteLine("4. Trapecio");
Console.WriteLine("5. Triangulo");
Console.Write("Elige una figura (1-5): ");
int figura = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("1. Area");
Console.WriteLine("2. Perimetro");
Console.WriteLine("3. Ambos");
Console.Write("Elige una opcion (1-3): ");
int operacion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

switch (figura)
{
    case 1: // Cuadrado
        Console.Write("Medida del lado: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());

        if (operacion == 1)
        {
            Console.WriteLine($"Area: {ladoC * ladoC}");
        }
        if (operacion == 2)
        {
            Console.WriteLine($"Perimetro: {ladoC * 4}");
        }
        if (operacion == 3)
        {
            Console.WriteLine($"Area: {ladoC * ladoC}");
            Console.WriteLine($"Perimetro: {ladoC * 4}");
        }
        break;

    case 2: // Círculo
        Console.Write("Medida del radio: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        if (operacion == 1)
        {
            Console.WriteLine($"Area: {3.1416 * radio * radio}");
        }
        if (operacion == 2)
        {
            Console.WriteLine($"Perimetro: {2 * 3.1416 * radio}");
        }
        if (operacion == 3)
        {
            Console.WriteLine($"Area: {3.1416 * radio * radio}");
            Console.WriteLine($"Perimetro: {2 * 3.1416 * radio}");
        }
        break;

    case 3: // Rombo
        Console.Write("Diagonal Mayor: ");
        double D = Convert.ToDouble(Console.ReadLine());
        Console.Write("Diagonal Menor: ");
        double d = Convert.ToDouble(Console.ReadLine());
        Console.Write("Medida de un lado: ");
        double ladoR = Convert.ToDouble(Console.ReadLine());

        if (operacion == 1)
        {
            Console.WriteLine($"Area: {(D * d) / 2}");
        }
        if (operacion == 2)
        {
            Console.WriteLine($"Perimetro: {ladoR * 4}");
        }
        if (operacion == 3)
        {
            Console.WriteLine($"Area: {(D * d) / 2}");
            Console.WriteLine($"Perimetro: {ladoR * 4}");
        }
        break;

    case 4: // Trapecio
        Console.Write("Base Mayor: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.Write("Base Menor: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lado izquierdo: ");
        double l1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lado derecho: ");
        double l2 = Convert.ToDouble(Console.ReadLine());

        if (operacion == 1)
        {
            Console.WriteLine($"Area: {((B + b) * h) / 2}");
        }
        if (operacion == 2)
        {
            Console.WriteLine($"Perimetro: {B + b + l1 + l2}");
        }
        if (operacion == 3)
        {
            Console.WriteLine($"Area: {((B + b) * h) / 2}");
            Console.WriteLine($"Perimetro: {B + b + l1 + l2}");
        }
        break;

    case 5: // Triángulo
        Console.Write("Base: ");
        double baseT = Convert.ToDouble(Console.ReadLine());
        Console.Write("Altura: ");
        double alturaT = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lado 2: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Lado 3: ");
        double lado3 = Convert.ToDouble(Console.ReadLine());

        if (operacion == 1)
        {
            Console.WriteLine($"Area: {(baseT * alturaT) / 2}");
        }
        if (operacion == 2)
        {
            Console.WriteLine($"Perimetro: {baseT + lado2 + lado3}");
        }
        if (operacion == 3)
        {
            Console.WriteLine($"Area: {(baseT * alturaT) / 2}");
            Console.WriteLine($"Perimetro: {baseT + lado2 + lado3}");
        }
        break;
}
