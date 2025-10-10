namespace Ejercicio1.Models.Exportares;

public interface IExportador
{
    bool Importar(string data, Multa m);
    string Exportar(Multa m);
}
