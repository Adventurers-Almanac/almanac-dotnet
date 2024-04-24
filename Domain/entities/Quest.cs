namespace AdventurersAlmanac.Domain.Entities
{

public class Quest: Entity
{

    public required string Name { get; set; }

    public string? Description { get; set; }

    public required string Client { get; set; }

    public required IList<string> Roles { get; set; }

    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }

    public string? Location { get; set; }

    public IList<string> Endeavors { get; set; } = new List<string>();

    public Quest(string name, string client, IList<string> roles, DateTime startDate, DateTime endDate): base()
    {
        this.Name = name;
        this.Client = client;
        this.Roles = roles;
        this.StartDate = startDate;
        this.EndDate = endDate;
    }

}

}