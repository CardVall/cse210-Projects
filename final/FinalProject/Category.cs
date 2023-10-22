using System;

public class Category : RecipeItem
{
    //Attributes

    //Constructors
    public Category()
    {

    }
    //Methods
    public void AddRecipe(Recipe recipe)
    {
        _recipies.Add(recipe);
    }
    public void RemoveRecipe(Recipe recipe)
    {
        _recipies.Remove(recipe);
    }
}