using System;


public class RecipeItem
{
    //Attributes
    protected string _name {get; set;}
    protected List<Recipe> _recipies {get; set;}
    //Constructors
    public RecipeItem()
    {

    }
    //Methods
    public void AddRecipe(Recipe recipe)
    {
        _recipies.Add(recipe);
    }

    public void removeRecipe(Recipe recipe)
    {
        _recipies.Remove(recipe);
    }
}