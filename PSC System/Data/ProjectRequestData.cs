using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PSC_System.Data.Model;
namespace PSC_System.Data
{
    public class ProjectRequestData : IProjectRequestData
    {
        private readonly ISqlDataAccess _db;

        public ProjectRequestData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProjectRequestModel>> GetRequest(string Id)
        {
            string sql = "select * from dbo.ProjectRequests WHERE UID = @Id";
            return _db.LoadData<ProjectRequestModel, dynamic>(sql, new { Id = Id });
        }

        public Task InsertField(ProjectRequestModel request)
        {
            string sql = @"insert into dbo.ProjectRequests (UPID,UID)
                           values (@Id,@GIVENTO,@UPID)";
            return _db.SaveData(sql, request);
        }

        public Task DeleteRequest(int RID)
        {
            string sql = @"DELETE FROM dbo.ProjectRequests WHERE RID = @rd";
            return _db.SaveData(sql,new {RID = RID});
            }
        }
    }
