using SQLite;

namespace BoulderBadge.Data;

public class Habit
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsCompleted { get; set; }
}
