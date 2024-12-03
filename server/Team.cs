namespace Gfa;

public class Team {
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<Person>? People { get; set; }
    public List<TournamentTableEntry>? TournamentTableEntries { get; set; }
    public List<Match>? Matches { get; set; }
}
