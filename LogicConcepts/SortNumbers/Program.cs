using Shared;


do
{
    Console.WriteLine("Ingrese 3 números diferentes");

    var a = ConsoleExtension.GetInt("Ingrese primer número : ");
    var b = ConsoleExtension.GetInt("Ingrese segundo número: ");
    if (a == b)
    {
        Console.WriteLine("Deben ser diferentes, intentelo de nuevo");
        continue;
    }

    var c = ConsoleExtension.GetInt("Ingrese tercer número : ");
    if (a == b || c == a)
    {
        Console.WriteLine("Deben ser diferentes, intentelo de nuevo");
        continue;
    }

    if (a > b && a > c)
    {
        if (b > c)
        {
            Console.WriteLine($"El mayor es {a}, el del medio es {b}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {a}, el del medio es {c}, el menor es {b}");
        }
    }
    else if (b > a && b > c)
    {
        if (a > c)
        {
            Console.WriteLine($"El mayor es {b}, el del medio es {a}, el menor es {c}");
        }
        else
        {
            Console.WriteLine($"El mayor es {b}, el del medio es {c}, el menor es {a}");
        }
    }

    else

    {
        if (a > b)
        {
            Console.WriteLine($"El mayor es {c}, el del medio es {a}, el menor es {b}");
        }
        else
        {
            Console.WriteLine($"El mayor es {c}, el del medio es {b}, el menor es {a}");
        }
    }
} while (true); 

