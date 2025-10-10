
using System.Globalization;

namespace Ejercicio1.Models.Exportadores;

public class CSVExportador : IExportador
{
    public string Exportar(Multa m)
    {
        return $"{m.Patente};{m.Vencimiento:dd/MM/yyyy};{m.Importar:f2}";
    }

    public bool Importar(string data, Multa m)
    {
        string[] campos=data.Split(';');
        
        m.Patente=campos[0].Trim();
        m.Vencimiento = DateOnly.ParseExact(campos[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
        m.Importe = Convert.ToDouble(campos[2]);

        return true;
    }
}
