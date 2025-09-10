namespace FinanTech.Application;

using FinanTech.Domain;
using System;

public class ApiDeliveryStrategy : IReportDeliveryStrategy
{
    public void Deliver(Report report)
    {
        Console.WriteLine($"Enviando reporte por API => {report}");
    }
}
