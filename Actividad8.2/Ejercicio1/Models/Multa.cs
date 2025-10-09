using Ejercicio1.Models.Exportadores;
using System.Net;

namespace Ejercicio1.Models;


public class Multa : IComparable, IExportable
{
    public string Patente { get; set; }
    public DateOnly Vencimiento {get; set; }
    public double Importe { get; set; }

    public Multa(string patente, DateOnly vencimiento, double importe)
    {
        this.Patente = patente;
        this.Vencimiento = vencimiento;
        this.Importe = importe;
    }

    public Multa()
    {
    }

    override public string ToString()
    {
        return $"{ Patente} (venc.:{Vencimiento:dd/MM/yyyy})  { Importe:f2}";
    }

    public int CompareTo(object otherObject)
    {
        Multa other = otherObject as Multa;
        if (other != null)
            return this.Patente.CompareTo(other.Patente);
        return -1;
    }

    public bool Importar(string data, IExportador exportador)
    {
        return exportador.Importar(data,this);
    }

    public string Exportar(IExportador exportador)
    {
        return exportador.Exportar(this);
    }
}
