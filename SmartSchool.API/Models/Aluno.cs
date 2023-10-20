using System.Reflection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartSchool.API.Models
{
    [Table("aluno")]
    public class Aluno
    {
        public Aluno() { }        
        public Aluno(int id, 
                     int matricula, 
                     string nome, 
                     string sobrenome, 
                     string telefone,
                     DateTime dataNasc)
        {
            this.Id = id;
            this.Matricula = matricula;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = telefone;
            this.DataNasc = dataNasc;
        }
        [Column("id")]
        public int Id { get; set; }
        [Column("matricula")]
        public int Matricula { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("sobrenome")]
        public string Sobrenome { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("datanasc")]
        public DateTime DataNasc { get; set; }
        [Column("dataini")]
        public DateTime DataIni { get; set; } = DateTime.Now;
        [Column("datafim")]
        public DateTime? DataFim { get; set; } = null;
        [Column("ativo")]
        public bool Ativo { get; set; } = true;
        public virtual IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set; }
    }
}