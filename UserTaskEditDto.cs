namespace SharedModels;

public class UserTaskEditDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public UserTaskStatus Status { get; set; }
    public UserTaskPriority Priority { get; set; }
    public DateTime? DueDate { get; set; }
}
