using Avalonia.Controls;
using ManagerDB.ViewModels;

namespace ManagerDB.Views;

public partial class FacultiesView : UserControl
{
    public FacultiesView()
    {
        InitializeComponent();

        Loaded += async (_, _) =>
        {
            if (DataContext is FacultiesViewModel viewModel)
                await viewModel.LoadAsync();
        };
    }
}