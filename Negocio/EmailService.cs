using System;
using System.Net.Mail;
using System.Net;

namespace Negocio
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService()
        {
            AccesoDatos datos = new AccesoDatos();
            string selectCredencialesMail = "select mail, " +
                                            "CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('Cultivo.2024', pass)) pass " +
                                            "from credencialesMail";
            string user = "";
            string pass = "";
            try
            {
                datos.SetearConsulta(selectCredencialesMail);
                datos.EjecutarLectura();

                if (datos.Lector.Read() == true)
                {
                    user = datos.Lector["mail"].ToString();
                    pass = datos.Lector["pass"].ToString();
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }

            try
            {
                server = new SmtpClient();
                server.Credentials = new NetworkCredential(user, pass);
                server.EnableSsl = true;
                server.Port = 587;
                server.Host = "smtp.gmail.com";
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
        }

        public void armarCorreo(string mailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@compugrossok.com", "CompuGross");
            email.To.Add(mailDestino);
            email.Subject = asunto;
            //email.IsBodyHtml = true;
            //email.Body = "<h1>Reporte de materias a las que se ha inscripto</h1> <br>Hola, te inscribiste.... bla bla";
            email.Body = cuerpo;
        }

        public void enviarEmail()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
