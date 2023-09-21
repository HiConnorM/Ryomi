using System.Collections.ObjectModel;
using System.ComponentModel;

public class HomePageViewModel : INotifyPropertyChanged
{
    public ObservableCollection<Recipe> TopRecipes { get; set; }

    public HomePageViewModel()
    {
        TopRecipes = new ObservableCollection<Recipe>
        {
            new Recipe { Name = "Recipe 1", Image = "steakaupoivre.jpg" },
            new Recipe { Name = "Recipe 2", Image = "swissburger.jpg" },
            // ... Add more recipes as needed
        };
    }

    public event PropertyChangedEventHandler PropertyChanged;
}

public class Recipe
{
    public string Name { get; set; }
    public string Image { get; set; }
}
