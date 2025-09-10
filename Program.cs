namespace FinanTech;

using System;
using FinanTech.Application;
using FinanTech.Domain;

public class Program
{
    static void Main(string[] args)
    {
        // PDF
        Console.WriteLine("*** Reporte PDF ***");
        var pdfBuilder = new PdfReportBuilder();
        var director = new ReportDirector(pdfBuilder);
        director.ConstructBasicReport("Reporte Ejecutivo", "Contenido de reporte ejecutivo");
        var pdfReport = pdfBuilder.Build();
        var emailDeliveryStrategy = new EmailDeliveryStrategy();
        emailDeliveryStrategy.Deliver(pdfReport);
        Console.WriteLine(Environment.NewLine);

        // Excel
        Console.WriteLine("*** Reporte Excel ***");
        var excelBuilder = new ExcelReportBuilder();
        director = new ReportDirector(excelBuilder);
        director.ConstructDetailedReport("Reporte Auditor", "Contenido de reporte auditor", "John Cena", DateTime.Now);
        var excelReport = excelBuilder.Build();
        var sharedFolderDeliveryStrategy = new SharedFolderDeliveryStrategy();
        sharedFolderDeliveryStrategy.Deliver(excelReport);
        Console.WriteLine(Environment.NewLine);

        // CSV
        Console.WriteLine("*** Reporte CSV ***");
        var csvBuilder = new CsvReportBuilder();
        director = new ReportDirector(csvBuilder);
        director.ConstructEncryptedReport("Reporte Analista", "Contenido de reporte analista", "asdlkj123");
        var csvReport = csvBuilder.Build();
        var apiDeliveryStrategy = new ApiDeliveryStrategy();
        apiDeliveryStrategy.Deliver(csvReport);
    }
}
