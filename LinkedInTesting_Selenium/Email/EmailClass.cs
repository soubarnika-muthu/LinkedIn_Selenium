/*Project =Selenium Automation Testing -LinkedIn 
 * created by = Soubarnika Muthu
 * date = 23/09/21
 */
using NUnit.Framework;
using System;
using System.Net;
using System.Net.Mail;


namespace LinkedInTesting_Selenium.Email
{
    public class EmailClass : Base.BaseClass
    {
        public static ExcelOperationForEmail excel;
        //Here we are reading the data from excel
        [SetUp]
        public void LaunchMailPage()
        {
            driver.Url = "https://accounts.google.com/ServiceLogin/identifier?";
        }
        public static void ReadDataFromExcel()
        {
            excel = new ExcelOperationForEmail();
            excel.PopulateInCollection(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\TestDataFiles\EmailData.xlsx");
        }

        public static void email_send()
        {
            try
            {
                excel = new ExcelOperationForEmail();
                MailMessage mail = new MailMessage();
                // Gmail SMTP server address
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //Sender Email Address
                mail.From = new MailAddress(excel.ReadData(1, "FromMail"));
                //Receiver Email Address  
                mail.To.Add(excel.ReadData(1, "ToMail"));
                //Subject of the mail is added
                mail.Subject = "Linkedin test mail";
                //Body of the mail is added
                mail.Body = "mail with amazon report attachmement";
                Attachment attachment;
                attachment = new Attachment(@"C:\Users\soubarnika.v\source\repos\LinkedInTesting_Selenium\LinkedInTesting_Selenium\Reports\index.html");
                Assert.NotNull(attachment);
                //here we attach the report of the automation
                mail.Attachments.Add(attachment);
                SmtpServer.Port = 587;
                // Gmail user authentication
                SmtpServer.Credentials = new NetworkCredential(excel.ReadData(1, "FromMail"), excel.ReadData(1, "Password"));
                SmtpServer.EnableSsl = true;
                //Here we click send mail 
                Console.WriteLine("started to send email...");
                SmtpServer.Send(mail);
                Console.WriteLine("email was sent successfully!");
            }

            catch (Exception e)
            {
                Console.WriteLine("failed to send email with the following error:");
                Console.WriteLine(e.Message);
            }
        }
    }
}