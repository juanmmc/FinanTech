namespace FinanTech.Application;

using FinanTech.Domain;
using System;

public class EmailDeliveryStrategy : IReportDeliveryStrategy
{
    public void Deliver(Report report)
    {
        Console.WriteLine($"Enviando reporte por correo: [{report}]");
    }
}
