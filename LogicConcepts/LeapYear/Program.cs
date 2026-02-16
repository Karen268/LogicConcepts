using Shared;

do
{
    var CurrentYear = DateTime.Now.Year;
    var Message = String.Empty;
    var Year = ConsoleExtension.GetInt("Ingrese año: ");
    
    if (Year == CurrentYear)
    {
        Message = "es";
    }
    else if (Year > CurrentYear)
    {
        Message = "va a ser";
    }
    else 
    {
        Message = "fue";
    }

    if (Year % 4 == 0)
    {
        if (Year % 100 == 0)
        {
            if (Year % 400 == 0)
            {
                Console.WriteLine($"El año: {Year} Si {Message} bisiesto");
            }
            else
            { 
                Console.WriteLine($"El año: {Year} No {Message} bisiesto");
            }
        }
        else
        {
            Console.WriteLine($"El año: {Year} Si {Message} bisiesto");
        }
    }
    else
    {
        Console.WriteLine($"El año: {Year} No {Message} bisiesto");
    }
} while (true);
