using System.Collections.Generic;

namespace BlazorAppWeb
{
  public class ToDoList
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public List<ToDoItem> Items { get; set; }
  }
}
