using System;


public  class RecipeItem
{
    //Attributes
    protected string _name {get; set;}
    protected List<Recipe> _recipes {get;} = new List<Recipe>();
    //Constructors
    public RecipeItem()
    {

    }
    public RecipeItem(string recipes)
    {

    }
    //Methods
    public List<Recipe> Recipes
    {
        get {return _recipes; }
    }
    public void AddRecipe(Recipe recipe)
    {
        _recipes.Add(recipe);
    }

    public void removeRecipe(Recipe recipe)
    {
        _recipes.Remove(recipe);
    }

}