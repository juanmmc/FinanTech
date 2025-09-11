namespace FinanTech.Application;

using FinanTech.Domain;

public class AuditorProcessingStrategy : IProcessingStrategy
{
    public string Process(string content)
    {
        return content + " [Detalle Auditoría]";
    }
}
