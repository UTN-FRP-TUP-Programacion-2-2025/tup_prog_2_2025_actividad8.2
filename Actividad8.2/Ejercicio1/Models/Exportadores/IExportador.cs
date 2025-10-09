using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Exportadores;

public interface IExportador
{
    bool Importar(Multa m, string data);
    string Exportar(Multa m);   
}
