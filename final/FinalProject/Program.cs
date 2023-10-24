using System;
using System.Linq;
using System.IO;




public class Program
{
    private static RecipeManager recipeManager = new RecipeManager();
    private static List<User> users = new List<User>();
    static void Main(string[] args)
    {
        

        HandleUserInput();

        void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to the Recipe Manager");
            Console.WriteLine("Please choose an option from the following menu: ");
            Console.WriteLine(" 1. Create a recipe");
            Console.WriteLine(" 2. List of recipes");
            Console.WriteLine(" 3. Rate a recipe");
            Console.WriteLine(" 4. Share a recipe");
            Console.WriteLine(" 5. Create a user");
            Console.WriteLine(" 6. Exit");
            Console.Write("User choice: ");
        }
        
        void HandleUserInput()
        {
            bool keepRunning = true;
            
            while (keepRunning)
            {
                DisplayMainMenu();

                string userInput = Console.ReadLine();
                int choice = int.Parse(userInput);

                if (choice == 1)
                {
                    CreateRecipe();
                }
                else if (choice == 2)
                {
                    DisplayRecipes();
                    Console.WriteLine("Enter your choice: ");
                    string userChoice = Console.ReadLine();

                    if (userChoice == "A" || userChoice == "a")
                    {
                        ListAllRecipes();
                    }
                    else
                    {
                        DisplayCategoryRecipes(userChoice);
                    }
                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {

                }
                else if (choice == 5)
                {
                    CreateUser();
                }
                else if (choice == 6)
                {
                    keepRunning = false;
                }
                else
                {
                    Console.Write("Invalid entry, please try again.");
                }
            }

        }
        
        void CreateRecipe()
        {
            Console.WriteLine("Enter the category of the recipe: ");
            string recipeCategory = Console.ReadLine();
            
            Console.Write("Enter the name of the recipe: ");
            string recipeName = Console.ReadLine();

            Recipe newRecipe = new Recipe(recipeName, recipeCategory);

            Console.WriteLine("Enter the ingredients (one per line, press Enter to finish): ");
            string ingredient;

            do
            {
                ingredient = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(ingredient))
                {
                    newRecipe.AddIngredient(ingredient);
                }
            } while (!string.IsNullOrWhiteSpace(ingredient));


            Console.WriteLine("Enter the steps (one per line, press Enter to finish): ");
            string step;

            do
            {
                step = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(step))
                {
                    newRecipe.AddStep(step);
                }
            } while (!string.IsNullOrWhiteSpace(step));

            recipeManager.AddRecipeItem(newRecipe);
            // SaveRecipes();
        }

        void DisplayRecipeDetails(Recipe recipe)
        {
            Console.WriteLine($"Recipe: {recipe.GetName()}");
            Console.WriteLine($"Category: {recipe._category}");
            
            Console.WriteLine("\nIngredients:");
            foreach (var ingredient in recipe.GetIngredients())
            {
                Console.WriteLine($"- {ingredient}");
            }

            Console.WriteLine("\nSteps:");
            foreach (var step in recipe.GetSteps())
            {
                Console.WriteLine($"- {step}");
            }
        }

        void DisplayRecipes()
        {
            Console.WriteLine("Available Categories:");

            var categories = recipeManager._recipes
            .OfType<Recipe>()
            .Select(recipe => recipe._category)
            .Distinct();

            foreach (var category in categories)
            {
                Console.WriteLine(category);
            }

            Console.WriteLine("A. All Recipes");
        }
        
        void ListAllRecipes()
        {

            Console.WriteLine("All Recipes:");

            List<Recipe> recipes = new List<Recipe>();

            foreach (RecipeItem item in recipeManager._recipes)
            {
                if (item is Recipe recipe)
                {
                    recipes.Add(recipe);
                }
            }

            for (int i = 0; i < recipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipes[i].GetName()}");
            }

            if (recipes.Count == 0)
            {
                Console.WriteLine("No recipes found.");
                return;
            }

            Console.WriteLine("\nEnter the number of the recipe to view details, or enter '0' to go back: ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);

            if (choice >= 1 && choice <= recipes.Count)
            {
                DisplayRecipeDetails(recipes[choice - 1]);
            }            
        }

        void DisplayCategoryRecipes(string category)
        {
            Console.WriteLine($"Recipes in the category '{category}':");

            List<Recipe> matchingRecipes = new List<Recipe>();

            foreach (RecipeItem item in recipeManager._recipes)
            {
                if (item is Recipe recipe && recipe._category == category)
                {
                    matchingRecipes.Add(recipe);
                }
            }

            for (int i = 0; i < matchingRecipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {matchingRecipes[i].GetName()}");
            }

            if (matchingRecipes.Count == 0)
            {
                Console.WriteLine($"No recipes found in the category '{category}'.");
                return;
            }

            Console.WriteLine("\nEnter the number of the recipe to view details, or enter '0' to go back: ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);

            if (choice >= 1 && choice <= matchingRecipes.Count)
            {
                DisplayRecipeDetails(matchingRecipes[choice - 1]);
            }
        }

        void CreateUser()
        {
            Console.WriteLine("Enter the username for the new user: ");
            
            // After much debate I have determined that "username" is one word.
            string username = Console.ReadLine();

            User newUser = new User(username);
            users.Add(newUser);

            Console.WriteLine($"User '{username}' has been created!");
            SaveUsers();
        }

        void SaveUsers()
        {
            string fileName = "MasterUserList.txt";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (var user in users)
                {
                    outputFile.WriteLine(user.ToString());
                }
            }
        }

        // void SaveRecipes()
        // {
        //     Console.WriteLine("What would you like to name the file?");
        //     string fileName = Console.ReadLine();
            
        //     using (StreamWriter outputFile = new StreamWriter(fileName))
        //     {
        //         foreach (var recipeItem in recipeManager._recipes)
        //         {
        //             if (recipeItem is Recipe recipe)
        //             {
        //                 outputFile.WriteLine(recipe.StringFormat());
        //             }
        //         }
        //     }
        // }
    }


}