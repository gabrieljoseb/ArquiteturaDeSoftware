using SOLID.DIP.Solucao.Interfaces;
using System.Net.Mail;

namespace SOLID.DIP.Solucao
{
    public class EmailService : IEmailServices
    {
        public void Enviar(string de, string para, string assunto, string mensagem)
        {
            var mail = new MailMessage(de, para);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.goolge.com"
            };

            mail.Subject = assunto;
            mail.Body = mensagem;
            client.Send(mail);
        }
    }
}
