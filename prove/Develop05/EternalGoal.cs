using System;

public class EternalGoal : Goal
{
    //---Attributes---
    

    //---Constructors---
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
        
    }


    //---Methods---
    public override void RecordEvent()
    {

    }
    
    public override bool IsComplete()
    {
        return true;
    }
    
    public override string GetStringRepresentation()
    {
        return $"Eternal Goal, {base._shortName}, {base._description}, {base._points} ";
    }


}