using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSchool.API.Models
{
    [Table("alunodisciplina")]
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;
        }
        [Column("dataini")]
        public DateTime DataIni { get; set; } = DateTime.Now;
        [Column("datafim")]
        public DateTime? DataFim { get; set; } = null;
        [Column("nota")]
        public int? Nota { get; set; } = null;
        [Column("alunoid")]
        public int AlunoId { get; set; }
        public virtual Aluno Aluno { get; set; }
        [Column("disciplinaid")]
        public int DisciplinaId { get; set; }
        public virtual Disciplina Disciplina { get; set; }       
    }
}