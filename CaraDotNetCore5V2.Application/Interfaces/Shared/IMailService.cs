using CaraDotNetCore5V2.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}