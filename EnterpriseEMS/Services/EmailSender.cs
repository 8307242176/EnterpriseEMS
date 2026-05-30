using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using MimeKit;

namespace EnterpriseEMS.Services;

public class EmailSender :
Microsoft.AspNetCore.Identity.UI.Services.IEmailSender
{

    private readonly IConfiguration _config;

    public EmailSender(IConfiguration config)
    {
        _config = config;
    }


    public async Task SendEmailAsync(string email,string subject,string htmlMessage)
    {

        var message =
        new MimeMessage();

        message.From.Add(MailboxAddress.Parse(_config["EmailSettings:Email"]));

        message.To.Add(
        MailboxAddress.Parse(email));

        message.Subject = subject;

        message.Body =new TextPart("html")
        {
            Text = htmlMessage
        };


        using var smtp =new SmtpClient();

        await smtp.ConnectAsync(_config["EmailSettings:Host"], int.Parse(_config["EmailSettings:Port"]),

        MailKit.Security.SecureSocketOptions.StartTls);


        await smtp.AuthenticateAsync(_config["EmailSettings:Email"],_config["EmailSettings:Password"]);


        await smtp.SendAsync(message);

        await smtp.DisconnectAsync(true);

    }

}