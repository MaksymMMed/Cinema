using MailKit.Net.Smtp;
using MimeKit;

namespace Cinema.EmailService.Sender
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _configuration;

        public EmailSender(EmailConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendConfirmationEmailAsync(string email, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Cinema", _configuration.From));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = "Confirm your email";
            emailMessage.Body = new TextPart("html") { Text = GenerateConfirmationEmailBody(message) };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration.SmtpServer, int.Parse(_configuration.Port), true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.AuthenticateAsync(_configuration.UserName, _configuration.Password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }

        public async Task SendResetPasswordEmailAsync(string email, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Cinema", _configuration.From));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = "Reset password";
            emailMessage.Body = new TextPart("html") { Text = GenerateResetPasswordEmailBody(message) };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration.SmtpServer, int.Parse(_configuration.Port), true);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.AuthenticateAsync(_configuration.UserName, _configuration.Password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }

        private string GenerateConfirmationEmailBody(string confirmationLink)
        {
            return $@"
            <html>
            <body>
                <h2>Email Confirmation</h2>
                <p>Please click the button below to confirm your account.</p>
                <form action='{confirmationLink}' method='post'>
                    <button type='submit'>Confirm Email</button>
                </form>
            </body>
            </html>";
        }

        private string GenerateResetPasswordEmailBody(string token)
        {
            return $@"
            <html>
            <body>
                <h2>Reset password</h2>
                <p>Use token below to reset password.</p>
                <p>{token}</p>
            </body>
            </html>";
        }

    }
}
