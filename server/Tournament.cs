namespace Gfa;

public class Tournament {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public TournamentTable Table { get; set; } = null!;
}
