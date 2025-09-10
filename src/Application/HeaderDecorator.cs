namespace FinanTech.Application;

using FinanTech.Domain;

public class HeaderDecorator : ReportDecorator
{
    private string _header;
    public HeaderDecorator(Report report, string header) : base(report)
    {
        _header = header;
    }
    public override string ToString()
    {
        return $"[Header: {_header}] " + _report.ToString();
    }
}
