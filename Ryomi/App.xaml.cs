using Microsoft.EntityFrameworkCore;

namespace Ryomi;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DbContext>(options =>
            options.UseSqlite("Filename=mydatabase.db"));
        // ... other services
    }

}



