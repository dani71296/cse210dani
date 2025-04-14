using System;

class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string ShortName { get { return _shortName; } }
    public string Description { get { return _description; } }
    public int Points { get { return _points; } }
    
    public Goal (string shortName, string description, int points)
    {
       _shortName=shortName;
       _description=description;
       _points=points;
    }
    public virtual void RecordEvent()
    {
    
    }   

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}