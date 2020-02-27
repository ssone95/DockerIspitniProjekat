using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BlazorUI.Helpers
{
    public static class MailHelper
    {
        public static string SendMail(OrderFormDTO orderForm)
        {
            try
            {
                string emailFromEnv = Environment.GetEnvironmentVariable("EMAIL_FROM");
                string emailFromAccountEnv = Environment.GetEnvironmentVariable("EMAIL_FROM_ACCOUNT");
                string emailFromAccountPasswordEnv = Environment.GetEnvironmentVariable("EMAIL_FROM_ACCOUNT_PASSWORD");
                string smtpAddressFromEnv = Environment.GetEnvironmentVariable("EMAIL_SMTP_ADDRESS");
                int smtpPortFromEnv = Int32.Parse(Environment.GetEnvironmentVariable("EMAIL_SMTP_PORT"));

                string orderEmailContent = $"Hello, an order was received from user {orderForm.FirstName} {orderForm.LastName}, with email {orderForm.EmailAddress}<br/>" +
                    $"Delivery address: {orderForm.Address}, {orderForm.Address2}, <br/>{orderForm.ZipCode}, {orderForm.City}, {orderForm.Country}. <br/>" +
                    $"Company: {orderForm.Company}.<br/>" +
                    $"Contact phone: {orderForm.PhoneNo}. <br/><br/>" +
                    $"Products:<br/>";

                foreach(var item in orderForm.ShoppingCart.ShoppingCartItems)
                {
                    orderEmailContent += $"{item.Product.Name} - €{item.TotalItemPrice} ({item.Quantity} x {item.Product.CalculatedPrice})<br/>";
                }

                orderEmailContent += $"Transport: €{orderForm.ShoppingCart.ShippingValue}<br/>Total: €{orderForm.ShoppingCart.TotalValue}<br/><br/>If this order was not intended, please contact us at {emailFromEnv}.";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFromEnv);
                    mail.To.Add(orderForm.EmailAddress);
                    mail.Subject = "New Order";
                    mail.Body = orderEmailContent;
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient(smtpAddressFromEnv, smtpPortFromEnv))
                    {
                        smtp.Host = smtpAddressFromEnv;
                        smtp.Port = smtpPortFromEnv;
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(emailFromEnv, emailFromAccountPasswordEnv);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(orderForm.EmailAddress);
                    mail.To.Add(emailFromEnv);
                    mail.Subject = $"New Order - {orderForm.EmailAddress}";
                    mail.Body = orderEmailContent;
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = smtpAddressFromEnv;
                        smtp.Port = smtpPortFromEnv;
                        smtp.UseDefaultCredentials = false;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(emailFromEnv, emailFromAccountPasswordEnv);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

            }
            catch (SmtpFailedRecipientException exception)
            {
                Debug.WriteLine(exception.StackTrace);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
            }
            return string.Empty;
        }
    }
}
