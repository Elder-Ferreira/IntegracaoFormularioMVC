namespace IntegracaoFormularioMVC.Models
{
    public class LivrosModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public bool CapaDura { get; set; }
        public DateTime DataCompra { get; set; } = DateTime.Now;
    }
}
