namespace MadLibs.Models
{
  public class MadLibModels
  {
    private string _name;
    private string _place;
    private string _exclamation;
    private string _adjective;
    private string _seoson;

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetPlace()
    {
      return _place;
    }
    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }
    public string GetExclamation()
    {
      return _exclamation;
    }
    public void SetExclamation(string newExclamation)
    {
      _exclamation = newExclamation;
    }
    public string GetAdjective()
    {
      return _adjective;
    }
    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }
    public string GetSeoson()
    {
      return _seoson;
    }
    public void SetSeoson( string newSeoson)
    {
      _seoson = newSeoson;
    }
  }
}
