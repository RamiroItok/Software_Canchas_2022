using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Composite
{
    public enum Permiso
    {
        EsFamilia,
        AltaUsuario,
        ModificarUsuario,
        BajaUsuario,
        DetalleProducto,
        GenerarPedidoStock,
        GenerarPedidoStockFijados,
        FijarProducto,
        GenerarAlertaPedidoStock,
        VisualizarPedidosStock,
        DetallePedidoStock,
        RecibirPedidoStock,
        PublicarProducto,
        ListarProductos,
        RealizarVenta,
        VisualizarVentas,
        AltaAutor,
        ModificarAutor,
        BajaAutor,
        AltaEditorial,
        ModificarEditorial,
        BajaEditorial,
        AltaGenero,
        ModificarGenero,
        BajaGenero,
        AltaIdioma,
        CargarEtiquetas,
        ModificarEtiquetas,
        GestionFamiliaPatente,
        GestionPermisosUsuarios,
        InformarACompras,
        CompletarInforme
    }
}
