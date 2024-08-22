using System;

namespace PCDF.Servico.Sicola.API.Domain.Entities
{
    public class Mensagem
    {
        public int Codigo { get; set; }
        public Usuario Remetente { get; set; }
        public Usuario Destinatario { get; set; }
        public DateTime? DataMensagem { get; set; }
        public string Corpo { get; set; }
        public string Assunto { get; set; }
    }
}
