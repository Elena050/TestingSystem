namespace TestingSystem.Models;

public class Test
{
  public int Id {get; set;}
  public string Title {get; set;} = string.Empty;
  public string Description {get; set;} = string.Empty;
  public bool IsPublished {get; set;} = true;
  public List<Question> Questions {get; set} = new();
}
