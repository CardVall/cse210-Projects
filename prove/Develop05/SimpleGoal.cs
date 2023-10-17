using System;

public class SimpleGoal : Goal
{
    //---Attributes---
    protected bool _isComplete;
    protected string goalName;
    protected string goalDesc;
    protected string goalPoints;

    //---Constructors---
    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
        goalName = name;
        goalDesc = description;
        goalPoints = points;

    }


    //---Methods---
    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        
        return _isComplete;
    }
    
    public override string GetStringRepresentation()
    {
        return $"Simple Goal,{goalName},{goalDesc},{goalPoints},{_isComplete}";
    }


}