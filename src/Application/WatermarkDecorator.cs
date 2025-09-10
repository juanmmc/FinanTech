namespace FinanTech.Application;

using FinanTech.Domain;

public class WatermarkDecorator : ReportDecorator
{
    private string _watermark;
    public WatermarkDecorator(Report report, string watermark) : base(report)
    {
        _watermark = watermark;
    }
    public override string ToString()
    {
        return _report.ToString() + $" [Watermark: {_watermark}]";
    }
}
