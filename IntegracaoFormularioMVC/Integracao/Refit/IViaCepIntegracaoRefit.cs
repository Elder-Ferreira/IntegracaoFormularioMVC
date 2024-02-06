using IntegracaoFormularioMVC.Integracao.Response;
using Refit;

namespace IntegracaoFormularioMVC.Integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
