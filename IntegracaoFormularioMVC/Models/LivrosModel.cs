using System.ComponentModel.DataAnnotations;

namespace IntegracaoFormularioMVC.Models
{
    public class LivrosModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o título do livro!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Digite o nome do autor!")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Digite o número de páginas!")]
        public int Paginas { get; set; }
        [Required(ErrorMessage = "Informe se o livro possui capa especial!")]
        public bool CapaDura { get; set; }
        public DateTime DataCompra { get; set; } = DateTime.Now;
    }
}
