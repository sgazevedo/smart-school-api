using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSchool.API.Models
{
    [Table("alunocurso")]
    public class AlunoCurso
    {
        public AlunoCurso() { }
        public AlunoCurso(int alunoId, int cursoId)
        {
            this.AlunoId = alunoId;
            this.CursoId = cursoId;
        }
        [Column("dataini")]
        public DateTime DataIni { get; set; } = DateTime.Now;
        [Column("datafim")]
        public DateTime? DataFim { get; set; }
        [Column("alunoid")]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        [Column("cursoid")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}