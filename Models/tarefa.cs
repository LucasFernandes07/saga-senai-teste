using System;
using System.ComponentModel.DataAnnotations;

namespace SeuProjeto.Models
{
    public class Tarefa
    {
        // Identificador único da tarefa (chave primária no banco de dados)
        public int Id { get; set; }

        // Nome da tarefa (obrigatório e com no máximo 50 caracteres)
        [Required(ErrorMessage = "O nome da tarefa é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres.")]
        public string Nome { get; set; } = null!;

        // Descrição detalhada da tarefa (não obrigatória, mas limitada a 200 caracteres)
        [StringLength(200, ErrorMessage = "A descrição deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; } = null!;

        // Data em que a tarefa foi criada (só aceita formato de data)
        [DataType(DataType.Date)]
        public DateTime DataCriacao { get; set; }

        // Data limite prevista para concluir a tarefa
        [DataType(DataType.Date)]
        public DateTime DataPrevista { get; set; }

        // Se a tarefa foi concluída ou não (true/false)
        public bool Concluida { get; set; }
    }
}
