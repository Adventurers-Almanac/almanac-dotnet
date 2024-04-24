namespace AdventurersAlmanac.Domain.Entities
{
public class Almanac: Aggregate
{
    public required Profile Profile { get; set; }

    public required Background Background { get; set; }

    public required IList<Summon> Summons { get; set; }

    public required IList<Studies> Studies { get; set; }

    public required IList<Guild> Guilds { get; set; }


    public Almanac(Profile profile, Background background, IList<Summon> summons, IList<Studies> studies, IList<Guild> guilds): base()
    
    {
        Profile = profile;
        Background = background;
        Summons = summons;
        Studies = studies;
        Guilds = guilds;
    }
}

}