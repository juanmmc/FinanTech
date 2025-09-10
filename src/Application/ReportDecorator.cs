namespace FinanTech.Application;

using FinanTech.Domain;

public abstract class ReportDecorator : Report
{
    protected Report _report;
    public ReportDecorator(Report report)
    {
        _report = report;
    }
    public abstract override string ToString();
}
