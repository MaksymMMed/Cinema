namespace Cinema.EmailService.Sender
{
    public interface IEmailSender
    {
        Task SendConfirmationEmailAsync(string email, string message);
    }
}
