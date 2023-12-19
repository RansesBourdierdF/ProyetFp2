using Microsoft.AspNetCore.Mvc;

namespace ClienteController.Controllers
{
    public class ClienteController : Controller
    {
        private readonly HttpClient _httpClient;

        public ClienteController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            // Obtener lista de clientes desde la API
            var response = await _httpClient.GetAsync("https://tuapi.com/api/Cliente/GetCliente");
            if (response.IsSuccessStatusCode)
            {
                var clientes = await response.Content.ReadAsAsync<List<ClienteModel>>();
                return View(clientes);
            }

            return View("Error");
        }

        
    }
}
