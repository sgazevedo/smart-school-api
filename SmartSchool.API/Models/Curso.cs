using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSchool.API.Models
{
    [Table("curso")]
    public class Curso
    {
        public Curso() { }
        public Curso(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        public virtual IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}