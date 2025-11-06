namespace TestingSystem.Models;

public class Variant
{ 
  public int Id {get; set;}
  public string Word {get; set} = string.Empty;
  public bool IsCorrect {get; set;} 
  public int Position {get; set;}
  public int QuestionId {get; set;}
}

public class VariantDto
{
  public int Id {get; set;}
  public string word {get; set;} = string.Empty;
  public int Position {get; set;}
}

public class TestSubmissionDto
{
  public int TestId {get; set;}
  public List<QuestionAnswerDto> Answers {get; set;} = new();
}

public class TestResultDto
{
  public int TestId {get; set;}
  public int TotalScore {get; set;}
  public int MaxScore {get; set;}
  public List<QuestionResultDto> QuestionResults {get; set;}
}

public class QuestionResultDto
{
  public int QusrionId {get; set;}
  public bool IsCorrect {get; set;}
  public int Score {get; set;}
  public string? CorrectAnswer {get; set;}
  public string? Explanation {get; set;}
}
