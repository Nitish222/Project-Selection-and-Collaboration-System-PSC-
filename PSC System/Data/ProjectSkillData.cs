using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PSC_System.Data.Model;



namespace PSC_System.Data
{
    public class ProjectSkillData : IProjectSkillData
    {
        private readonly ISqlDataAccess _db;

        public ProjectSkillData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProjectSkillsModel>> GetAllProjectSkills()
        {
            string sql = "select * from dbo.ProjectSkills";
            return _db.LoadData<ProjectSkillsModel, dynamic>(sql, new { });
        }

        public Task<List<ProjectSkillsModel>> GetProjectSkills(int UPID)
        {
            string sql = "select * from dbo.ProjectSkills Where PID = @UPID";
            return _db.LoadData<ProjectSkillsModel, dynamic>(sql, new { UPID = UPID });
        }
    }
}
