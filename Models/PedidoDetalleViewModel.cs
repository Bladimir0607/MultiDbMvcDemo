namespace MultiDbMvcDemo.Models
{
    public class PedidoDetalleViewModel
    {
        public List<Pedido> Pedidos { get; set; } = new();
        public List<DetallePedido> Detalles { get; set; } = new();
    }
}