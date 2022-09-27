using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using PSC_System.Data.Model;
namespace PSC_System.Data
{
    public class SkillScoreData : ISkillScoreData
    {
        private readonly ISqlDataAccess _db;

        public SkillScoreData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<SkillScoreModel>> GetSkilScore(string Id)
        {
            string sql = "select * from dbo.SKILLSCORE WHERE Id = @Id";
            return _db.LoadData<SkillScoreModel, dynamic>(sql, new { Id = Id });
        }

        public Task InsertField(SkillScoreModel score)
        {
            string sql = @"insert into dbo.SKILLSCORE (Id,GIVENTO,UPID)
                           values (@Id,@GIVENTO,@UPID)";
            return _db.SaveData(sql, score);
        }
    }
}
