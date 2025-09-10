namespace FinanTech.Domain;

using System;

public interface IReportBuilder
{
    void Reset();
    void SetTitle(string title);
    void SetContent(string content);
    void SetAuthor(string author);
    void SetCreationDate(DateTime creationDate);
    void SetProcessingLevel(string level);
    Report Build();
}
