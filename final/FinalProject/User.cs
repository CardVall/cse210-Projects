using System;

class User
{
    //Attributes
    public string _userName {get; set;}
    public List<Recipe> _savedRecipes {get; set;}
    public List<Recipe> _sharedRecipes {get; set;}
    //Constructors
    public User()
    {

    }
    //Methods
    public void saveRecipe(Recipe recipe)
    {
        _savedRecipes.Add(recipe);
    }
    public void unsaveRecipe(Recipe recipe)
    {
        _savedRecipes.Remove(recipe);
    }
    public void ShareRecipe(Recipe recipe, User user)
    {
        user._savedRecipes.Add(recipe);
    }
}