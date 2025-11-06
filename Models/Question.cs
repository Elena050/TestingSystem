namespace TestingSystem.Models;

public class Question
{
  public int Id {get; set;}
  public string TaskText {get; set;} = string.Empty;
  public string Exampletext :get; set;} = string.Empry;
  public QuestionType Tyoe {get; set;}
  public int QuestionNumber {get; set;}
  public int Points {get; set;} = 1;
  public string? Explanation {get; set}
  public int TestId {get; set}
public List<Variant> Variants {get; set} = new();
}
