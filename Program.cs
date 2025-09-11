namespace FinanTech;

using System;
using FinanTech.Application;
using FinanTech.Domain;

public class Program
{
    static void Main(string[] args)
    {
        // PDF
        Console.WriteLine("*** PDF");
        // Estrategia de procesamiento para ejecutivos
        var executiveProcessing = new ExecutiveProcessingStrategy();
        string executiveContent = executiveProcessing.Process("Contenido de reporte ejecutivo");
        var pdfBuilder = new PdfReportBuilder();
        var director = new ReportDirector(pdfBuilder);
        director.ConstructBasicReport("Reporte Ejecutivo", executiveContent);
        Report pdfReport = pdfBuilder.Build();
        // Decoradores: encabezado y marca de agua
        Report decoratedPdf = new HeaderDecorator(pdfReport, "Confidencial");
        decoratedPdf = new WatermarkDecorator(decoratedPdf, "FinanTech Solutions");
        // Entrega por correo
        var emailDeliveryStrategy = new EmailDeliveryStrategy();
        emailDeliveryStrategy.Deliver(decoratedPdf);

        // Excel
        Console.WriteLine("*** Excel");
        // Estrategia de procesamiento para auditores
        var auditorProcessing = new AuditorProcessingStrategy();
        string auditorContent = auditorProcessing.Process("Contenido de reporte auditor");
        var excelBuilder = new ExcelReportBuilder();
        director = new ReportDirector(excelBuilder);
        director.ConstructDetailedReport("Reporte Auditor", auditorContent, "John Cena", DateTime.Now);
        Report excelReport = excelBuilder.Build();
        // Decoradores: marca de agua y compresión
        Report decoratedExcel = new WatermarkDecorator(excelReport, "FinanTech Solutions");
        decoratedExcel = new CompressionDecorator(decoratedExcel);
        // Entrega en carpeta compartida
        var sharedFolderDeliveryStrategy = new SharedFolderDeliveryStrategy();
        sharedFolderDeliveryStrategy.Deliver(decoratedExcel);

        // CSV
        Console.WriteLine("*** CSV");
        // Estrategia de procesamiento para analistas
        var analystProcessing = new AnalystProcessingStrategy();
        string analystContent = analystProcessing.Process("Contenido de reporte analista");
        var csvBuilder = new CsvReportBuilder();
        director = new ReportDirector(csvBuilder);
        director.ConstructEncryptedReport("Reporte Analista", analystContent, "asdlkj123");
        Report csvReport = csvBuilder.Build();
        // Decoradores: encabezado y compresión
        Report decoratedCsv = new HeaderDecorator(csvReport, "Confidencial");
        decoratedCsv = new CompressionDecorator(decoratedCsv);
        // Entrega por API
        var apiDeliveryStrategy = new ApiDeliveryStrategy();
        apiDeliveryStrategy.Deliver(decoratedCsv);
    }
}
