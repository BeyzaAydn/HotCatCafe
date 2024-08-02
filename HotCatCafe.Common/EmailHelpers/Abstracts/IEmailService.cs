namespace HotCatCafe.Common.EmailHelpers.Abstracts
{
    public interface IEmailService
    {
        Task SendMessageAsync(string to, string subject, string body);
    }
}
