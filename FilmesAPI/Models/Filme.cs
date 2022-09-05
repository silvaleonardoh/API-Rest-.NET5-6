using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Titulo Obrigatório")]
        public string Titulo{ get; set; }
        [Required(ErrorMessage = "Campo Diretor Obrigatório")]
        public string Diretor{ get; set; }
        public string Genero { get; set; }
        [Range(1,1800, ErrorMessage = "Minimo 1, Maximo 1800")]
        public int Duracao { get; set; }
        
    }
}
