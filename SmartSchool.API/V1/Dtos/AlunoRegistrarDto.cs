using System;

namespace SmartSchool.API.V1.Dtos
{
    /// <summary>
    /// Este é o DTO de Aluno para Registrar.
    /// </summary>
    public class AlunoRegistrarDto
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
        /// Nome do Aluno
        /// </summary>     
        public string Nome { get; set; }
        /// <summary>
        /// Sobrenome do Aluno
        /// </summary>  
        public string Sobrenome { get; set; }
        /// <summary>
        /// Telefone do Aluno
        /// </summary> 
        public string Telefone { get; set; }
        /// <summary>
        /// Data de nascimento do Aluno
        /// </summary> 
        public DateTime DataNasc { get; set; }
        /// <summary>
        /// Data de início ou entrada do aluno na instituição.
        /// </summary>
        public DateTime DataIni { get; set; } = DateTime.Now;
        /// <summary>
        /// Data de finalização ou saída do aluno na instituição.
        /// </summary>
        public DateTime? DataFim { get; set; } = null;
        /// <summary>
        /// Ativar ou não o Aluno
        /// </summary>
        public bool Ativo { get; set; } = true;
    }
}