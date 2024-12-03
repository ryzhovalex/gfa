namespace Gfa;

public class Match {
    public enum MatchState {
        Wait,
        Ongoing,
        Finished,
    }

    public int Id { get; set; }
    public MatchState State { get; set; }
    public Team? Team1 { get; set; }
    public Team? Team2 { get; set; }
    public Tournament? Tournament { get; set; }
    public List<MatchEvent>? Events { get; set; }
}
