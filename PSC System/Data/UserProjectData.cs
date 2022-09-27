using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PSC_System.Data.Model;

namespace PSC_System.Data
{
    public class UserProjectData : IUserProjectData
    {
        private readonly ISqlDataAccess _db;

        public UserProjectData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<UserProjectModel>> GetUserProject(string Id)
        {
            string sql = "select dbo.UserProjects.UPID,dbo.UserProjects.PTIME,dbo.UserProjects.PID, dbo.UserProjects.Id, dbo.Projects.ProjectName from dbo.UserProjects INNER JOIN dbo.Projects ON Projects.PID = UserProjects.PID WHERE Id = @Id; ";
            return _db.LoadData<UserProjectModel, dynamic>(sql, new { Id = Id });
        }

        public Task<List<UserProjectModel>> GetAllProject()
        {
            string sql = "select dbo.UserProjects.UPID,dbo.UserProjects.PTIME,dbo.UserProjects.PID, dbo.UserProjects.Id, dbo.Projects.ProjectName from dbo.UserProjects INNER JOIN dbo.Projects ON Projects.PID = UserProjects.PID; ";
            return _db.LoadData<UserProjectModel, dynamic>(sql, new { });
        }

        public Task InsertUserProject(UserProjectModel proj)
        {
            string sql = @"insert into dbo.UserProjects (PID,PTIME,Id)
                           values (@PID,@PTIME,@Id)";
            return _db.SaveData(sql, proj);
        }
    }
}
