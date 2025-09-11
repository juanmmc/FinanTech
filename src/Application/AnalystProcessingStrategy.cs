namespace FinanTech.Application;

using FinanTech.Domain;

public class AnalystProcessingStrategy : IProcessingStrategy
{
    public string Process(string content)
    {
        return content + " [Datos Técnicos]";
    }
}
