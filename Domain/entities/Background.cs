namespace AdventurersAlmanac.Domain.Entities
{
public class Background: Entity
{
    public required BackgroundType Type { get; set; }

    public required string Title { get; set; }

    public required string Description { get; set; }

    public bool IsPrimary { get; set; }
    public bool IsEnabled { get; set; }

    public short PriorityOrder { get; set; }



    public Background(BackgroundType type, string title, string description): base()
    {
        this.Type = type;
        this.Title = title;
        this.Description = description;
    }



}

public enum BackgroundType
{
    Unknown,
    Professional,
    Personal,
    Fictional
}


/*
            "type": "string",
            "value": "string",
            "isPrimary": "bool",
            "isEnabled": "bool",
            "priorityOrder": "number"

*/

}