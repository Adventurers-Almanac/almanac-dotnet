namespace AdventurersAlmanac.Domain.Entities
{

public class Profile: Entity
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required DateTime DateOfBirth { get; set; }

    public IList<string> Hobbies { get; set; } = new List<string>();

    public Profile(string firstName, string lastName, DateTime dateOfBirth): base()
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.DateOfBirth = dateOfBirth;
    }

    public void AddHobby(string hobby)
    {
        if(this.Hobbies == null) 
        {
            this.Hobbies = new List<string>();
        }

        this.Hobbies.Add(hobby);
    }
}

}