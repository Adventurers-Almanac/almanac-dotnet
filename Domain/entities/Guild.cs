namespace AdventurersAlmanac.Domain.Entities
{
public class Guild: Entity
{
    public required string Name { get; set; }
    public string? Description { get; set; }

    public string? Location { get; set; }

    public IList<string> Endeavors { get; set; } = new List<string>();


    public IList<Quest> Quests { get; set; } = new List<Quest>();

    public Guild(string name): base()
    {
        this.Name = name;
    }

}


/*

{
            "company": {
                "name": "string",
                "location": "string (address)",
                "overview": "string",
                "activities": [
                    "string"
                ],
                "type": [
                    "string"
                ],
                "projects": [
                    {
                        "name": "string",
                        "client": "string",
                        "roles": [
                            "string"
                        ],
                        "startDate": "string (Date)",
                        "endDate": "string (Date)",
                        "location": "string (address)",
                        "overview": "string",
                        "activities": [
                            "string"
                        ]
                    }
                ]
            }
        }

*/

}