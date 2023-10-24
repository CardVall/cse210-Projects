using System;

public class Recipe : RecipeItem
{
    //Attributes
    protected List<string> _ingredients {get; set;}
    protected List<string> _steps {get; set;}
    public string _category {get; set;}

    //Constructors
    public Recipe(string recipeName, string recipeCategory)
    {
        _name = recipeName;
        _ingredients = new List<string>();
        _steps = new List<string>();
        _category = recipeCategory;
    }
    //Methods
    public string GetName()
    {
        return _name;
    }
    public List<string> GetIngredients()
    {
        return _ingredients;
    }
    public List<string> GetSteps()
    {
        return _steps;
    }
    public void AddIngredient(string ingredient)
    {
        _ingredients.Add(ingredient);
    }
    public void RemoveIngredient(string ingredient)
    {
        _ingredients.Remove(ingredient);
    }
    public void AddStep(string step)
    {
        _steps.Add(step);
    }
    public void RemoveStep(string step)
    {
        _steps.Remove(step);
    }

    // public string StringFormat()
    // {
    //     return $"{_category},{base._name},{string.Join(",",_ingredients)},{string.Join(",",_steps)}";
    // }

}