using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_.Models;

public interface IExportable
{
    bool Importar(string data, IExportador exportador);
    string Exportar( IExportador exportador)
}
