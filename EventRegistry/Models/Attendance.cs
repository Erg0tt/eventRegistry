using EventRegistrationApp;

public class Attendance
{
    public int Id { get; set; }
    public Participant Participant { get; set; }
    public Event Event { get; set; }
    public bool IsPresent { get; set; }
}
