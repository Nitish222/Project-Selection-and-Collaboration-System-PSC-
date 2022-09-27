using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface ISkillScoreData
    {
        Task<List<SkillScoreModel>> GetSkilScore(string Id);
        Task InsertField(SkillScoreModel score);
    }
}