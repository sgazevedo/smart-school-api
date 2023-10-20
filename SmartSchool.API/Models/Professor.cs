using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSchool.API.Models
{
    [Table("professor")]
    public class Professor
    {
        public Professor() { }
        public Professor(int id, int registro, string nome, string sobrenome)
        {
            this.Id = id;
            this.Registro = registro;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("registro")]
        public int Registro { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("sobrenome")]
        public string Sobrenome { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("dataini")]
        public DateTime DataIni { get; set; } = DateTime.Now;
        [Column("datafim")]
        public DateTime? DataFim { get; set; } = null;
        [Column("ativo")]
        public bool Ativo { get; set; } = true;
        public virtual IEnumerable<Disciplina> Disciplinas { get; set; }
    }
}