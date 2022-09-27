using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface ISkillData
    {
        Task<List<SkillModel>> GetSkills();
        Task InsertSkills(SkillModel skill);
    }
}