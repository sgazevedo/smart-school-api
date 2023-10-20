using System;

namespace SmartSchool.API.V1.Dtos
{
    /// <summary>
    /// Este é o DTO para retorno do Aluno.
    /// </summary>
    public class AlunoDto
    {
        /// <summary>
        /// Identificador e chave do Banco
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Chave do Aluno, para outros negócios na Instituição
        /// </summary>
        public int Matricula { get; set; }     
        /// <summary>
        /// Nome é o Primeiro nome e o Sobrenome do Aluno
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Telefone do Aluno
        /// </summary>
        public string Telefone { get; set; }
        /// <summary>
        /// Esta idade é o calculo relacionado a data de nascimento do Aluno
        /// </summary>
        public int Idade { get; set; }
        /// <summary>
        /// Data de início ou entrada do aluno na instituição.
        /// </summary>
        public DateTime DataIni { get; set; }
        /// <summary>
        /// Se o Aluno está ativo ou não na instituição.
        /// </summary>
        public bool Ativo { get; set; }
    }
}