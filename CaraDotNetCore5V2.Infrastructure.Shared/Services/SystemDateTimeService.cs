using CaraDotNetCore5V2.Application.Interfaces.Shared;
using System;

namespace CaraDotNetCore5V2.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}