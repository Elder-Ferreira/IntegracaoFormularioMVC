using System.ComponentModel.DataAnnotations;

namespace IntegracaoFormularioMVC.Models
{
    public class UsuarioModel
    {
        [Key]
        public string UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
