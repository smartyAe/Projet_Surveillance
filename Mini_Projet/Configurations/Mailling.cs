using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Projet
{
    class Mailling
    {

        private string adresse;
        private string subject= "Programme de surveillance";
        private string message;
        private string join;

        public string Propadresses
        {
            get { return adresse ; }
            set { adresse  = value; }
        }
        public string Propsubject
        {
            get { return subject; }
            set { subject = value; }
        }
        public string Propmessage
        {
            get { return message; }
            set { message = value; }
        }
        public string Propjoin
        {
            get { return join; }
            set { join = value; }
        }
        public void SendMail()
        {

               MailMessage mail = new MailMessage();
                //ajouter le  destinataire 
                mail.To.Add(adresse); 
                mail.Subject = subject;
                mail.Body = message;
                //définir l'expéditeur
                mail.From = new MailAddress("no-replay@mon-site.fr", "Webmaster & News");


                // Attach a document.  
                mail.Attachments.Add(new Attachment(join,MediaTypeNames.Application.Pdf));

                //définir les paramètres smtp pour l'envoi
                SmtpClient smtpServer = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 465,
                    EnableSsl = false,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("montestcka@gmail.com", "mot de passe ")
                };
                //envoi du mail
                smtpServer.Send(mail);
            
         
    }
}
}
