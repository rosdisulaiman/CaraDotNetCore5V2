using CaraDotNetCore5V2.Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface ILogRepository
    {
        Task<List<AuditLogResponse>> GetAuditLogsAsync(string userId);

        Task AddLogAsync(string action, string userId);
    }
}