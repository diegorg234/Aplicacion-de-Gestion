using CommunityToolkit.Mvvm.Input;
using Material.Icons;
using TiendaSegundaMano.Services;

namespace TiendaSegundaMano.ViewModels;

public partial class BienvenidaViewModel : ViewModelBase
{
    private readonly NavigationService _navigationService;

    public BienvenidaViewModel(NavigationService navigationService)
    {
        _navigationService = navigationService;
        Titulo = "Inicio";
        Icono = MaterialIconKind.Home;
    }

    [RelayCommand]
    private void IrAPublicar()
    {
        _navigationService.VistaActual = _navigationService.VistaAltas;
    }

    [RelayCommand]
    private void IrAExplorar()
    {
        _navigationService.VistaActual = _navigationService.VistaConsultas;
    }
}