public class TodoItem  
{  
    public string Title { get; set; }  
    public bool IsComplete { get; set; } = false;  

    public TodoItem(string title)  
    {  
        Title = title;  
    }  
}  