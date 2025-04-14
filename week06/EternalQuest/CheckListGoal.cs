using System;

class CheckListGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string shortName, string description, int points, int target, int bonus)
    : base(shortName, description, points)
    {
        _amountCompleted=0;
        _target=target;
        _bonus=bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
        // aquí es cuando se completa y se gana el bonus
        Console.WriteLine($"¡Goal Completed! you gain {Points + _bonus} points.");
        }
        else
        {
        Console.WriteLine($"¡goal registered! you Gain {Points} points.");
        }
    }

    
     public override bool IsComplete()
     {
        return _amountCompleted >= _target;
     }
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
    return $"{checkbox} {ShortName} ({Description}) -- Completed {_amountCompleted}/{_target} times";
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{ShortName},{Description},{Points},{_bonus},{_target},{_amountCompleted}";
    }
    public int GetBonus()
{
    return _bonus;
}
}

