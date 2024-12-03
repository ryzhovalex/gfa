namespace Gfa;

public class Team {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Person> People { get; set; } = null!;
    public List<TournamentTable> TournamentTables { get; set; } = null!;
}
