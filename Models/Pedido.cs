namespace MultiDbMvcDemo.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string ClienteNombre { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
    }
}