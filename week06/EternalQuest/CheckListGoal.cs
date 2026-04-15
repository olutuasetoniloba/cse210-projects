public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _current = 0;
    }

    public override int RecordEvent()
    {
        _current++;
        int points = GetPoints();

        if (_current == _target)
        {
            points += _bonus;
        }

        return points;
    }

    public override bool IsComplete() => _current >= _target;

    public override string GetStatus()
    {
        return $"[{(_current >= _target ? "X" : " ")}] Completed {_current}/{_target}";
    }

    public override string GetSaveString()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_current}|{_target}|{_bonus}";
    }
}