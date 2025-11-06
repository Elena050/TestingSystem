namespace TestingSystem.Models;

public class User
{
  public int Id {get; set;}
  public string Login {get; set;} = string.Empty;
  public string Password {get; set;} = string.Empty;
  public FirstName {get; set;} = string.Empty;
  public LastName {get; set;} = string.Empty;
  public string Role {get; set;} = "Student";
}

public enum QustionType
{
  Spelling = 9,
  SpellingPrefix = 10,
  SpellingSuffix = 11,
  PersonalEndings = 12,
  PatricleNOT = 13,
  HyphenSpelling = 15
}
