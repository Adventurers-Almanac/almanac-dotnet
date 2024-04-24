
namespace AdventurersAlmanac.Domain.Dtos
{
    public record CreateNewAlmanacCommand
    {
        public required string Name { get; set; }
        public required string Description { get; set; }

        public CreateNewAlmanacCommand()
        {
            // Empty constructor
        }

        public CreateNewAlmanacCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}