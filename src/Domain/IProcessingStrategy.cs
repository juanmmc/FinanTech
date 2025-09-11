namespace FinanTech.Domain;

public interface IProcessingStrategy
{
    string Process(string content);
}
