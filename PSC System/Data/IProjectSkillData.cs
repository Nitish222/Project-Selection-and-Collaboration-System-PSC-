using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IProjectSkillData
    {
        Task<List<ProjectSkillsModel>> GetAllProjectSkills();
        Task<List<ProjectSkillsModel>> GetProjectSkills(int UPID);
    }
}