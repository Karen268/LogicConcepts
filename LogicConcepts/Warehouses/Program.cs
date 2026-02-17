using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("*** DATOS DE ENTRADA ***");
    var CC = ConsoleExtension.GetDecimal("Costo de compra ($) ..................................: ");
    var TP = ConsoleExtension.GetValidOptions("Tipo de producto [P]erecedero, [N]o perecedero..............:", ["p", "n"]);
    var TC = ConsoleExtension.GetValidOptions("Tipo de conservacion [F]rio, [A]mbiente.....................:", ["f", "a"]);
    var PC = ConsoleExtension.GetInt("Periodo de conservacion (dias)...........................");
    var PA = ConsoleExtension.GetInt("Periodo de almacenamiento (dias)...........................");
    var VOL = ConsoleExtension.GetInt("Volumen (Litros)...........................");
    var MA = ConsoleExtension.GetValidOptions("Medio de almacenamiento [N]evera, [C]ongelador, [E]stanteria, [G]uacal: ", ["n", "c","e", "g"]);

    Console.WriteLine("*** CALCULOS ***");
    var CA = GetCostoAlmacenamiento(CC, TC, PC, VOL);
    var PDP = GetPorcentajeDepreciacionDelProducto(PA);
    var VR_V = GetValorVenta(TP, CC, CA, PDP);
    var CE = GetCostoExhibicion(TP, TC, MA);

    do
{
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?....: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

float GetPorcentajeDepreciacionDelProducto(int PA)  
{
    if (PA < )
}

decimal GetCostoExhibicion(string? tP, string? tC, string? mA)
{
    throw new NotImplementedException();
}
decimal GetValorVenta(string? TP, decimal CC, decimal CA, float PDP)

{
    throw new NotImplementedException();
}


decimal GetCostoAlmacenamiento(decimal CC, string? TC, int PC, int VOL)
{
    throw new NotImplementedException();
}