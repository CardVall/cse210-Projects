using System;


public abstract class Goal 
{
    //---Attributes---
    protected string _shortName;
    protected string _description;
    protected string _points;
    

    //---Constructors---
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //---Methods---
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return "";
    }

    public abstract string GetStringRepresentation();
}