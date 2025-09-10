namespace FinanTech.Application;

using FinanTech.Domain;

public class CompressionDecorator : ReportDecorator
{
    public CompressionDecorator(Report report) : base(report) {}
    public override string ToString()
    {
        return _report.ToString() + " [Compressed]";
    }
}
