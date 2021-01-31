namespace BlazorAppWeb
{
  public class ToDoItem
  {
    public int Id { get; set; }
    public int ToDoListId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Position { get; set; }
    public bool IsCompleted { get; set; }
  }
}
