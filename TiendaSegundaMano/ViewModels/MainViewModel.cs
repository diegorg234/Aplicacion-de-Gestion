using CommunityToolkit.Mvvm.ComponentModel;
using TiendaSegundaMano.Services;

namespace TiendaSegundaMano.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private NavigationService _navigationService = new();
}