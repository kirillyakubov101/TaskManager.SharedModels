namespace SharedModels
{
    public class UserTaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public UserTaskStatus Status { get; set; } = UserTaskStatus.Pending; // Enum: Pending, InProgress, Completed
        public UserTaskPriority Priority { get; set; } = UserTaskPriority.Normal; // Enum: Low, Normal, High
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DueDate { get; set; }
    }
}
