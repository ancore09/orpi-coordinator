namespace orpi_coordinator.Models;

public class Service
{
    public ulong Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public Dictionary<string, dynamic> Opts { get; set; }
}