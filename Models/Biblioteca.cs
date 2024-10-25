// Models/Biblioteca.cs
namespace BibliotecaApi.Models
{
    public class Biblioteca
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Inicio_Funcionamento { get; set; } 
        public string? Fim_Funcionamento { get; set; } 
        public int Inauguracao { get; set; }
        public string? Contato { get; set; }
    }
}
