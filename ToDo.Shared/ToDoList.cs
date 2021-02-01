using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToDo.Shared
{
  public class ToDoList
  {
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "The title must be between 3 and 100 characters long.")]
    public string Title { get; set; }
    public List<ToDoItem> Items { get; set; }
  }
}
