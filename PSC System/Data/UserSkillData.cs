using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSC_System.Data.Model;
namespace PSC_System.Data
{
    public class UserSkillData : IUserSkillData
    {
        private readonly ISqlDataAccess _db;

        public UserSkillData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserSkillJoinModel>> GetUserSkills(string Id)
        {
            string sql = "select dbo.UserSkills.Id,dbo.UserSkills.SID,dbo.Skills.SkillName from dbo.UserSkills INNER JOIN dbo.Skills ON UserSkills.SID = Skills.SID WHERE Id = @Id; ";
            return _db.LoadData<UserSkillJoinModel, dynamic>(sql, new { Id = Id });
        }

        public Task<List<UserSkillJoinModel>> GetSkills()
        {
            string sql = "select dbo.UserSkills.Id,dbo.UserSkills.SID,dbo.Skills.SkillName from dbo.UserSkills INNER JOIN dbo.Skills ON UserSkills.SID = Skills.SID; ";
            return _db.LoadData<UserSkillJoinModel, dynamic>(sql, new { });
        }


        public Task InsertSkills(UserSkillModel userskill)
        {
            string sql = @"insert into UserSkills (Id,SID)
                           values (@Id,@SID)";
            return _db.SaveData(sql, userskill);
        }
    }
}
