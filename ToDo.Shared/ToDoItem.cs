using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDo.Shared
{
  public class ToDoItem
  {
    [Key]
    public int Id { get; set; }
    [ForeignKey("ToDoListId")]
    public int ToDoListId { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "The title must be between 3 and 100 characters long.")]
    public string Title { get; set; }
    public string Description { get; set; }
    public int Position { get; set; }
    public bool IsCompleted { get; set; }
  }
}
