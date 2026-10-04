using System.Collections.ObjectModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ManagerDB.Data;
using ManagerDB.Models;

namespace ManagerDB.ViewModels;

public partial class FacultiesViewModel : ViewModelBase
{
    private readonly FacultyRepository _repository;

    public ObservableCollection<Faculty> Faculties { get; } = new();

    [ObservableProperty]
    private Faculty? selectedFaculty;

    [ObservableProperty]
    private string facultyName = "";

    public FacultiesViewModel(FacultyRepository repository)
    {
        _repository = repository;
    }

    public async Task LoadAsync()
    {
        Faculties.Clear();

        var faculties = await _repository.GetAllAsync();

        foreach (var faculty in faculties)
            Faculties.Add(faculty);
    }

    [RelayCommand]
    private async Task AddAsync()
    {
        var name = FacultyName.Trim();

        if (string.IsNullOrEmpty(name))
            return;

        await _repository.AddAsync(name);

        FacultyName = "";
        await LoadAsync();
    }

    [RelayCommand]
    private async Task DeleteAsync()
    {
        if (SelectedFaculty == null)
            return;

        await _repository.DeleteAsync(SelectedFaculty.Id);
        await LoadAsync();
    }
}