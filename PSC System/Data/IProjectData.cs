using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IProjectData
    {
        Task<List<ProjectModel>> GetProject();
        Task InsertProject(ProjectModel field);
    }
}