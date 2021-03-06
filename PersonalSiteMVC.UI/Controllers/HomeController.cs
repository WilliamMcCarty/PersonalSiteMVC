using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSiteMVC.UI;
using System.Net.Mail;
using System.Configuration;
using System.Net;
using PersonalSiteMVC.UI.Models;


namespace PersonalSiteMVC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Links()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactViewModel cvm)
        {
            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            string MyMessage = $"You have received an email from {cvm.Email} with a subject: {cvm.Subject}.  Please respond to {cvm.Email} with your response to the following message: <br/>{cvm.Message}";

            MailMessage mailMessage = new MailMessage(
            ConfigurationManager.AppSettings["EmailUser"].ToString(),            
            ConfigurationManager.AppSettings["EmailTo"].ToString(),
            cvm.Subject, 
            MyMessage);

            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;
            mailMessage.ReplyToList.Add(cvm.Email);

            SmtpClient mailClient = new SmtpClient(ConfigurationManager.AppSettings["EmailClient"].ToString());

            mailClient.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["EmailUser"].ToString(), ConfigurationManager.AppSettings["EmailPass"].ToString());

            mailClient.Port = 8889;



            try
            {
                mailClient.Send(mailMessage);
                ViewBag.SuccessMessage = "Thank you for contacting me, I will respond as soon as possible.";
            }
            catch (Exception ex)
            {
                ViewBag.SuccessMessage = "Please try again later, there was a issue sending the message.";
                ViewBag.ErrorMessage = $"We are sorry, but your request could not be completed at this time. " +
                    $"Please try again later.  Error Message: <br/> {ex.StackTrace}";
                return View(cvm);
            }

            return View();
        }
    }
}