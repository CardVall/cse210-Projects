using System;

class RecipeManager
{
    //Attributes
    public List<RecipeItem> _recipies {get; set;}
    //Constructors
    public RecipeManager()
    {

    }
    //Methods
    public void AddRecipeItem(RecipeItem item)
    {
        _recipies.Add(item);
    }
    public void EditRecipeItem(RecipeItem item)
    {

    }
    public void DeleteRecipeItem(RecipeItem item)
    {
        _recipies.Remove(item);
    }
    public void FilterByCategory(string _category)
    {

    }
}