using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SiteSaudacao.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet([FromServices]IConfiguration configuration)
        {
            string saudacao = configuration["Saudacao"];
            string titulo = configuration["PaginaInicial:Titulo"];
            string mensagem = configuration["PaginaInicial:Mensagem"];

            _logger.LogInformation(saudacao);
            _logger.LogInformation(titulo);
            _logger.LogInformation(mensagem);

            TempData["Saudacao"] = saudacao;
            TempData["Titulo"] = titulo;
            TempData["Mensagem"] = mensagem;
        }
    }
}