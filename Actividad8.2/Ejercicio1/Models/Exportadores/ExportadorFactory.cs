

namespace Ejercicio1.Models.Exportadores;

public class ExportadorFactory
{
    public IExportador GetInstance(int tipo) 
    {
        IExportador exportador = null;
        switch (tipo)
        {
            case 1: exportador = new CSVExportador(); break;
            case 2: exportador = new JSONExportador(); break;
            case 3: exportador = new CampoFijoExportador(); break;
            case 4: exportador = new XMLExportador(); break;
        }
        return exportador;
    }
}
