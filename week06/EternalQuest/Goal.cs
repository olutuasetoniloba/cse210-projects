public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStatus();
    public abstract string GetSaveString();
}