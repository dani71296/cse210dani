using System;

class SimpleGoal:Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
        {

        }
    public override void RecordEvent()
    {
        _isComplete= true;   
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        if (_isComplete== false)
        {
            return $"[ ] {ShortName} ({Points} points)";
        }
        else
        {
            return $"[X] {ShortName} ({Points} points)";
        }
        
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{ShortName},{Description},{Points},{_isComplete}";
    }

}