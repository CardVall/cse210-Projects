using System;

public class Recipe : RecipeItem
{
    //Attributes
    public List<string> ingredients {get; set;}
    public List<string> steps {get; set;}
    public string _category {get; set;}
    //Constructors
    public Recipe()
    {

    }
    //Methods
    public void AddIngredient(string ingredient)
    {
        ingredients.Add(ingredient);
    }
    public void RemoveIngredient(string ingredient)
    {
        ingredients.Remove(ingredient);
    }
    public void AddStep(string step)
    {
        steps.Add(step);
    }
    public void RemoveStep(string step)
    {
        steps.Remove(step);
    }
    public void ChangeCategory(string newCategory)
    {
        _category = newCategory;
    }
}