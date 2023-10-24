using System;

class User
{
    //Attributes
    public string _username {get; set;}
    public List<Recipe> _savedRecipes {get; set;}
    public List<Recipe> _sharedRecipes {get; set;}
    //Constructors
    public User(string username)
    {
        _username = username;
        _savedRecipes = new List<Recipe>();
        _sharedRecipes = new List<Recipe>();
    }
    public User(string userData, RecipeManager manager)
    {
        
        string[] parts = userData.Split(':');
        _username = parts[0];

        if (parts.Length > 1)
        {
            string[] recipeNames = parts[1].Split(',');
            _savedRecipes = manager.GetRecipesByName(recipeNames);
        }
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
    public override string ToString()
    {
        string savedRecipes = string.Join(",", _savedRecipes.Select(r => r.GetName()));
        return $"{_username}:{savedRecipes}";
    }
}