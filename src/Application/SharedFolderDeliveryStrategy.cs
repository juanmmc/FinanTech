namespace FinanTech.Application;

using FinanTech.Domain;
using System;

public class SharedFolderDeliveryStrategy : IReportDeliveryStrategy
{
    public void Deliver(Report report)
    {
        Console.WriteLine($"Guardando reporte en carpeta compartida: [{report}]");
    }
}
