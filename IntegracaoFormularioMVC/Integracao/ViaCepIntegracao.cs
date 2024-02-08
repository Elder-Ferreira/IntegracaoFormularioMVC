using IntegracaoFormularioMVC.Integracao.Interfaces;
using IntegracaoFormularioMVC.Integracao.Response;

namespace IntegracaoFormularioMVC.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        public async  Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
            throw new NotImplementedException();
        }
    }
}
