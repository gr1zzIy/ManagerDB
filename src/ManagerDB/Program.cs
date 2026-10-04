using Avalonia;
using System;
using System.Threading.Tasks;
using ManagerDB.Data;

namespace ManagerDB;

sealed class Program
{
    private const string ConnectionString = "Server=localhost;Database=university;User Id=sa;Password=StrongPassword2026!;TrustServerCertificate=True;";
    
    public static async Task TestDbConnection()
    {
        var facultyRep = new FacultyRepository(new DbConnectionFactory(ConnectionString));
        await facultyRep.DeleteAsync(5);

        var faculties = await facultyRep.GetAllAsync();
        
        Console.WriteLine("Faculties in the database:");
        foreach (var faculty in faculties)
        {
            Console.WriteLine($"{faculty.Id} - {faculty.Name}");
        }
    }
    
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
#if DEBUG
            .WithDeveloperTools()
#endif
            .WithInterFont()
            .LogToTrace();
            
}
