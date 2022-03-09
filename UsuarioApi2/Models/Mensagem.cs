using MimeKit;
using System.Collections.Generic;
using System.Linq;

namespace UsuarioApi.Models
{
    public class Mensagem
    {
        public List<MailboxAddress> Destinario { get; set; }
        public string Assunto { get; set; }
        public string Conteudo { get; set; }
        public Mensagem(IEnumerable<string> destinatario, string assunto, int usuarioId, string codigo)
        {
            Destinario = new List<MailboxAddress>();
            Destinario.AddRange(destinatario.Select(d => new MailboxAddress(d)));
            Assunto = assunto;
            Conteudo = $"http://localhost:6000/ativa?UsuarioId={usuarioId}&CodigoDeAtivacao={codigo}";
        }
    }
}
