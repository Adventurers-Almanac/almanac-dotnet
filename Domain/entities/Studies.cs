namespace AdventurersAlmanac.Domain.Entities
{

public class Studies: Entity
{
    public required string SchoolName { get; set; }
    public required StudyLevelType LevelType { get; set; }

    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }

    public required string Location { get; set; }

    public IList<string> Specialties { get; set; } = new List<string>();

    public Studies(string schoolName, StudyLevelType levelType, DateTime startDate, DateTime endDate, string location): base()
    {
        this.SchoolName = schoolName;
        this.LevelType = levelType;
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.Location = location;
    }
}


/*
{
            "schoolName": "string",
            "level": "string",
            "startDate": "string (Date)",
            "endDate": "string (Date)",
            "location": "string (address)",
            "specialties": [
                "string"
            ]
        }

*/



public enum StudyLevelType
{
    Unknown,
    MiddleSchool,
    HighSchool,
    Undergraduate,
    Graduate,
    Field,
    Voluntary,
    Arcane
}


}