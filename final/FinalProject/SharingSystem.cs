using System;


class SharingSystem
{
    //Attributes

    //Constructors
    public SharingSystem()
    {
        
    }
    //Methods
    public void ShareRecipe(Recipe recipe, User user)
    {
        user._savedRecipes.Add(recipe);
    }
}