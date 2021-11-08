using System;
using System.Threading;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Commit(CancellationToken cancellationToken);

        Task Rollback();
    }
}