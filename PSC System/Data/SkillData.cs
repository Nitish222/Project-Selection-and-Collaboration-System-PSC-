using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSC_System.Data.Model;

namespace PSC_System.Data.DataAccess
{
    public class SkillData : ISkillData
    {
        private readonly ISqlDataAccess _db;

        public SkillData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SkillModel>> GetSkills()
        {
            string sql = "select * from dbo.Skills";
            return _db.LoadData<SkillModel, dynamic>(sql, new { });
        }

        public Task InsertSkills(SkillModel skill)
        {
            string sql = @"insert into Skills (SID,SkillName)
                           values (@SID,@SkillName)";
            return _db.SaveData(sql, skill);
        }
    }
}
