using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Material.Icons;
using TiendaSegundaMano.Models;

namespace TiendaSegundaMano.ViewModels;

public partial class ConsultasViewModel : ViewModelBase
{
    [ObservableProperty] private string _textoBusqueda = string.Empty;
    [ObservableProperty] private AvaloniaList<Categoria> _listaCategorias = new();
    [ObservableProperty] private Categoria? _categoriaSeleccionada;

    [ObservableProperty] private AvaloniaList<Producto> _listaProductos = new();
    [ObservableProperty] private Producto? _productoSeleccionado;

    public ConsultasViewModel()
    {
        Titulo = "Explorar";
        Icono = MaterialIconKind.Magnify;
    }

    [RelayCommand]
    public void Buscar()
    {
        
    }

    [RelayCommand]
    public void LimpiarFiltros()
    {
        TextoBusqueda = string.Empty;
        CategoriaSeleccionada = null;
    }

    [RelayCommand]
    public void EditarProducto()
    {
        if (ProductoSeleccionado == null)
        {
            return;
        }

 
    }

    [RelayCommand]
    public void EliminarProducto()
    {
        if (ProductoSeleccionado == null)
        {
            return;
        }

       
    }
}