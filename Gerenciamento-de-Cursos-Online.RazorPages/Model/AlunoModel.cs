using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Cursos_Online.RazorPages.Models {
    public class AlunoModel {
        public int? IdAluno { get; set; }
        public string? NomeAluno { get; set; }
        public string? Email { get; set; }
        public DateTime? DataInscrição { get; set; }
        public List<CursoModel>? Cursos { get; set; } 
    }
}