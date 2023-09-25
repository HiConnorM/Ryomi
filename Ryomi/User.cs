using Ryomi;
namespace Ryomi
{
    public class User
    {
        public int UserID { get; set; } // Primary Key
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // Store hashed password, never plain text!
        public string ProfilePictureURL { get; set; } // URL pointing to Azure Blob storage or any other CDN.

        // Navigation Properties (for relationships, these can be filled in later)
        public ICollection<Recipe> Recipes { get; set; } // Recipes created by the user
        public ICollection<SavedRecipes> SavedRecipes { get; set; } // Recipes saved by the user
    }

}
