using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using TiendaSegundaMano.ViewModels;

namespace TiendaSegundaMano.Services;

public partial class NavigationService : ObservableObject
{
    [ObservableProperty] private AvaloniaList<ViewModelBase> _listaVistas = new();
    [ObservableProperty] private ViewModelBase _vistaActual;

    public BienvenidaViewModel VistaBienvenida { get; }
    public AltasViewModel VistaAltas { get; }
    public ConsultasViewModel VistaConsultas { get; }

    public NavigationService()
    {
        VistaBienvenida = new BienvenidaViewModel(this);
        VistaAltas = new AltasViewModel();
        VistaConsultas = new ConsultasViewModel();

        ListaVistas.Add(VistaBienvenida);
        ListaVistas.Add(VistaAltas);
        ListaVistas.Add(VistaConsultas);

        VistaActual = VistaBienvenida;
    }
}