using ToDo.Domain.Enum;

namespace ToDo.Domain.Entity;

public class TaskEntity
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    
    public TaskLevel Level { get; set; }
}