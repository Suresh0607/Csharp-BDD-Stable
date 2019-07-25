using NUnit.Framework;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;



namespace NUnit.InsightsRetail.CommonClasses
{
    public class MailUtils
    {

        public void SendMail()
        {
            MailMessage mail = new MailMessage();
            try
            {
                var Client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("automationtesting.invigor@gmail.com", "Suresh123"),
                    EnableSsl = true
                   
                };

                mail.From = new MailAddress("automationtesting.invigor@gmail.com");
                mail.To.Add("suresh.nammi@invigorgroup.com");
                mail.Subject = "Test Mail - 1";
                mail.Body = "mail with attachment"+"      "+"http://10.10.10.80/Automation_Results/InsightsRetail/Test_Execution_Reports/index.html";

                Client.Send(mail);
                
            }
            catch (Exception e)
            {
                throw (e);
            }

        }

    }
}

    