using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IProjectRequestData
    {
        Task DeleteRequest(int RID);
        Task<List<ProjectRequestModel>> GetRequest(string Id);
        Task InsertField(ProjectRequestModel request);
    }
}