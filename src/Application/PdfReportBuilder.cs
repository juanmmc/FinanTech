namespace FinanTech.Application;

using FinanTech.Domain;
using System;

public class PdfReportBuilder : IReportBuilder
{
    private Report _report = new Report();

    public void Reset()
    {
        _report = new Report();
    }

    public void SetTitle(string title)
    {
        _report.Title = title + " (PDF)";
    }

    public void SetContent(string content)
    {
        _report.Content = content;
    }

    public void SetAuthor(string author)
    {
        _report.Author = author;
    }

    public void SetCreationDate(DateTime creationDate)
    {
        _report.CreationDate = creationDate;
    }

    public void SetProcessingLevel(string level)
    {
        _report.ProcessingLevel = level;
    }

    public Report Build()
    {
        return _report;
    }
}
