namespace Cinema.EmailService.Sender
{
    public interface IEmailSender
    {
        Task SendConfirmationEmailAsync(string email, string message);
        Task SendResetPasswordEmailAsync(string email, string message);

    }
}
