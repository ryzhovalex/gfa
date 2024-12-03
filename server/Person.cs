namespace Gfa;

public class Person
{
    public enum PersonType {
        Player,
        Staff,
    }

    public enum PersonPosition {
        PlayerGoalkeeper,
        PlayerDefender,
        PlayerMidfielder,
        PlayerForward,

        StaffMainCoach,
        StaffHelpCoach,
        StaffMedic,
    }

    public int Id { get; set; }
    public string Firstname { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public int Age { get; set; }
    public PersonType Type { get; set; }
    public PersonPosition Position { get; set; }
    public Rating? Rating { get; set; }

    public List<Team>? Teams { get; set; }
}
