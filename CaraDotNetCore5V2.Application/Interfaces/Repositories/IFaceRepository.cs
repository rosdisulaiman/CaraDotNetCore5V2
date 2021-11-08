using CaraDotNetCore5V2.Domain.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Interfaces.Repositories
{
    public interface IFaceRepository
    {
        
        Task<List<Face>> GetListAsync();

        Task<Face> GetByIdAsync(int faceId);

        Task<int> InsertAsync(Face face);

        Task DeleteAsync(Face face);
    }
}
