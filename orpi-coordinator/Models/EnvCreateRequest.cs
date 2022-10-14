namespace orpi_coordinator.Models;

public class EnvCreateRequest
{
    public string Name { get; set; }
    public List<Service> Services { get; set; }
    public string Target { get; set; }
    public Dictionary<string, List<string>> Dependencies { get; set; }
}