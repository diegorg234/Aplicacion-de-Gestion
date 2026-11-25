using CommunityToolkit.Mvvm.ComponentModel;
using Material.Icons;

namespace TiendaSegundaMano.ViewModels;

public partial class ViewModelBase : ObservableObject
{
    [ObservableProperty] private string _titulo = string.Empty;
    [ObservableProperty] private MaterialIconKind _icono;
}