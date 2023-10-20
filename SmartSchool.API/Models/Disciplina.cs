using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSchool.API.Models
{
    [Table("disciplina")]
    public class Disciplina
    {
        public Disciplina() { }
        public Disciplina(int id, string nome, int professorId, int cursoId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;
            this.CursoId = cursoId;
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("cargahoraria")]
        public int CargaHoraria { get; set; }
        [Column("prerequisitoid")]
        public int? PrerequisitoId { get; set; } = null;
        public virtual Disciplina Prerequisito { get; set; }
        [Column("professorid")]
        public int ProfessorId { get; set; }
        public virtual Professor Professor { get; set; }
        [Column("cursoid")]
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}