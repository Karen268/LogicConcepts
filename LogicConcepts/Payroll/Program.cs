using Shared;

    var answer = String.Empty;
var options = new List<string> { "s", { "n" } };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre...........................................: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese número de horas trabajadas...................: ");
    var HourValue = ConsoleExtension.GetDecimal("Ingrese valor hora.................................: ");
    var salaryMinimun = ConsoleExtension.GetDecimal("Ingrese valor salario minimo mensual............: ");

    var salary = (decimal) workHours * HourValue;
    if (salary < salaryMinimun)
    {
        Console.WriteLine($"Nombre.....: {name} ");
        Console.WriteLine($"Salario....: {salaryMinimun:C2} ");
    }
    else
    {
        Console.WriteLine($"Nombre.....: {name}");
        Console.WriteLine($"Salario....: {salary:C2}");

    }

    do
    { 
    answer = ConsoleExtension.GetValidOptions("Deseas continuar [S]i [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Gracias");



    