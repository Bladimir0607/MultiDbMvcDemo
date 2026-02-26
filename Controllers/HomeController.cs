using Microsoft.AspNetCore.Mvc;
using MultiDbMvcDemo.Data;
using MultiDbMvcDemo.Models;

namespace MultiDbMvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly SqlServerContext _sqlContext;
        private readonly MySqlContext _mySqlContext;

        public HomeController(SqlServerContext sqlContext, MySqlContext mySqlContext)
        {
            _sqlContext = sqlContext;
            _mySqlContext = mySqlContext;
        }

        public IActionResult Index()
        {
            var pedidos = _sqlContext.Pedidos.ToList();
            var detalles = _mySqlContext.DetallesPedido.ToList();

            var viewModel = new PedidoDetalleViewModel
            {
                Pedidos = pedidos,
                Detalles = detalles
            };

            return View(viewModel);
        }
    }
}