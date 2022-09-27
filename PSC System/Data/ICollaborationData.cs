using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface ICollaborationData
    {
        Task<List<CollaborationModel>> GetProjectUsers(int UPID);
        Task<List<CollaborationModel>> GetTeam();
        Task InsertCollaboration(CollaborationModel member);
    }
}