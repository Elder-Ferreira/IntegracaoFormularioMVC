using IntegracaoFormularioMVC.Integracao.Response;

namespace IntegracaoFormularioMVC.Integracao.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
