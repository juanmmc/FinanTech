namespace FinanTech.Application;

using FinanTech.Domain;

public class ExecutiveProcessingStrategy : IProcessingStrategy
{
    public string Process(string content)
    {
        return content + " [Resumen Ejecutivo]";
    }
}
