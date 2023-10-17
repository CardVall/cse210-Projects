using System;


public class ChecklistGoal : Goal
{
    //---Attributes---
    private int  _amountCompleted;
    private int _target;
    private int _bonus;


    //---Constructors---
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
        
    }


    //---Methods---
    public override void RecordEvent()
    {
        _amountCompleted ++;

    }
    
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"-- Currently completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"Checklist Goal,{base._shortName},{base._description},{base._points},{_target},{_bonus},{_amountCompleted}";
    }


}