using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IUserProjectData
    {
        Task<List<UserProjectModel>> GetAllProject();
        Task<List<UserProjectModel>> GetUserProject(string Id);
        Task InsertUserProject(UserProjectModel proj);
    }
}