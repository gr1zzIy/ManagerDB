using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ManagerDB.Data;
using ManagerDB.ViewModels;
using ManagerDB.Views;

namespace ManagerDB;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            const string connectionString =
                "Server=localhost,1433;" +
                "Database=university;" +
                "User Id=sa;" +
                "Password=StrongPassword2026!;" +
                "Encrypt=True;" +
                "TrustServerCertificate=True;";

            var connectionFactory = new DbConnectionFactory(connectionString);
            var facultyRepository = new FacultyRepository(connectionFactory);
            var facultiesViewModel = new FacultiesViewModel(facultyRepository);

            desktop.MainWindow = new MainWindow
            {
                DataContext = facultiesViewModel
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}