using BadmintonShop.BusinessObjects.Entity.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BadmintonShop.Services.Services.Implements;

public class EmailService: IEmailSender<Account>
{
    public Task SendConfirmationLinkAsync(Account user, string email, string confirmationLink)
    {
        Console.WriteLine(confirmationLink);
        return Task.CompletedTask;
    }

    public Task SendPasswordResetLinkAsync(Account user, string email, string resetLink)
    {
        Console.WriteLine(resetLink);
        return Task.CompletedTask;
    }

    public Task SendPasswordResetCodeAsync(Account user, string email, string resetCode)
    {
        Console.WriteLine(resetCode);
        return Task.CompletedTask;
    }
}