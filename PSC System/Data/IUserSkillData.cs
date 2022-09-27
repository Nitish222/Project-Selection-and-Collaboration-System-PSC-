using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IUserSkillData
    {
        Task<List<UserSkillJoinModel>> GetSkills();
        Task<List<UserSkillJoinModel>> GetUserSkills(string Id);
        Task InsertSkills(UserSkillModel userskill);
    }
}