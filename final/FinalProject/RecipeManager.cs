using System;

class RecipeManager
{
    //Attributes
    public List<RecipeItem> _recipes {get; set;}
    //Constructors
    public RecipeManager()
    {
        _recipes = new List<RecipeItem>();
    }
    //Methods
    public List<Recipe> GetRecipesByName(IEnumerable<string> names)
    {
        return _recipes.OfType<Recipe>().Where(r => names.Contains(r.GetName())).ToList();
    }
    public void AddRecipeItem(RecipeItem item)
    {
        _recipes.Add(item);
    }
    public void EditRecipeItem(RecipeItem item)
    {

    }
    public void DeleteRecipeItem(RecipeItem item)
    {
        _recipes.Remove(item);
    }
    public void FilterByCategory(string _category)
    {

    }
}