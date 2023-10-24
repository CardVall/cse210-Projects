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
        _recipes.Add(recipe);
    }
    public void RemoveRecipe(Recipe recipe)
    {
        _recipes.Remove(recipe);
    }
}