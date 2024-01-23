namespace EmailApplication
{
    public interface IEmailService
    {
        Task<EmailResponseModel> SendEmailAsync(EmailRequestModel emailRequestModel);
    }
}
