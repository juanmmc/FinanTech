namespace FinanTech.Domain;

public interface IReportDeliveryStrategy
{
    void Deliver(Report report);
}
