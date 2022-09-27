using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PSC_System.Data.Model;

namespace PSC_System.Data
{
    public class ProjectData : IProjectData
    {
        private readonly ISqlDataAccess _db;

        public ProjectData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProjectModel>> GetProject()
        {
            string sql = "select * from dbo.Projects";
            return _db.LoadData<ProjectModel, dynamic>(sql, new { });
        }

        public Task InsertProject(ProjectModel field)
        {
            string sql = @"insert into dbo.Projects (ProjectName,FID)
                           values (@ProjectName,@FID)";
            return _db.SaveData(sql, field);
        }
    }
}
