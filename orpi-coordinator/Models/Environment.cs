namespace orpi_coordinator.Models;

public class Environment
{
    public ulong Id { get; set; }
    public string Name { get; set; }
    public List<Service> Services { get; set; }
    public string Target { get; set; }
}