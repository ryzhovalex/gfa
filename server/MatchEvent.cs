namespace Gfa;

public class MatchEvent {
    public enum MatchEventType {
        Goal,
        RefereeWarning,
        YellowCard,
        RedCard,
        CornerKick,
        FreeKick,
        Penalty,
        HalfTime,
    }

    public int Id { get; set; }
    public MatchEventType Type { get; set; }
    public List<Person>? Participants { get; set; }
}
