namespace FinanTech.Application;

using FinanTech.Domain;
using System;

public class ReportDirector
{
    private IReportBuilder _builder;

    public ReportDirector(IReportBuilder builder)
    {
        _builder = builder;
    }

    // Básico
    public void ConstructBasicReport(string title, string content)
    {
        _builder.Reset();
        _builder.SetTitle(title);
        _builder.SetContent(content);
        _builder.SetProcessingLevel("Básico");
    }

    // Detallado
    public void ConstructDetailedReport(string title, string content, string author, DateTime creationDate)
    {
        _builder.Reset();
        _builder.SetTitle(title);
        _builder.SetContent(content);
        _builder.SetAuthor(author);
        _builder.SetCreationDate(creationDate);
        _builder.SetProcessingLevel("Detallado");
    }

    // Encriptado
    public void ConstructEncryptedReport(string title, string content, string key)
    {
        _builder.Reset();
        _builder.SetTitle(title);
        _builder.SetContent(content);
        _builder.SetProcessingLevel($"Encriptado con clave: {key}");
    }
}
