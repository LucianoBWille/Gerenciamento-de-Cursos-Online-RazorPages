using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerenciamento_de_Cursos_Online.RazorPages.Models {
    public class CursoModel {
        public int? IdCurso { get; set; }
        public string? NomeCurso { get; set; }
        public string? Descrição { get; set; }
        public DateTime? DataInício { get; set; }
        public DateTime? DataTérmino { get; set; }
        public List<AlunosModel>? Alunos { get; set; } 
    }
}