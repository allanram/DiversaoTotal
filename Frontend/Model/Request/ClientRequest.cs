using System.ComponentModel.DataAnnotations;

namespace Frontend.Model.Request
{
    public class ClientRequest
    {
        [Required (ErrorMessage = "Nome é obrigatório")]
        [StringLength (100, MinimumLength = 10, ErrorMessage = "Nome deve ter no minimo 10 caracteres")]

        public string Nome { get; set; }
        [Required (ErrorMessage = "Data de nascimento é obrigatório")]
        public DateTime Nascimento { get; set; }
    }
}
