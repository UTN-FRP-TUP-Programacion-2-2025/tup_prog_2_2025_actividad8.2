namespace Ejercicio1_.Models;

public interface IExportador
{
    bool Importar(string data, Multa m);
    string Exportar(Multa m);
}
