
using System.Globalization;

namespace Ejercicio1.Models.Exportadores;

public class CSVExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return $"{m.Patente};{m.Vencimiento:dd/MM/yyyy};{m.Importar:f2}";
    }

    public bool Importar(Multa m, string data)
    {
        string[] campos=data.Split(';');
        
        m.Patente=campos[0].Trim();
        _ = DateTime.TryParseExact(campos[1],"dd/MM/yyyyy",CultureInfo.InvariantCulture, DateTimeStyles.None,out DateTime date);
        m.Vencimiento = new DateOnly(date.Year, date.Month, date.Day);
        m.Importe = Convert.ToDouble(campos[2]);

        return true;
    }
}
