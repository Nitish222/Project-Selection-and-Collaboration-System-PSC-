using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PSC_System.Data.Model;

namespace PSC_System.Data
{
    public class CollaborationData : ICollaborationData
    {
        private readonly ISqlDataAccess _db;

        public CollaborationData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CollaborationModel>> GetTeam()
        {
            string sql = "select * from dbo.Collaboration";
            return _db.LoadData<CollaborationModel, dynamic>(sql, new { });
        }

        public Task<List<CollaborationModel>> GetProjectUsers(int UPID)
        {
            string sql = "select * from dbo.Collaboration Where UPID = @UPID";
            return _db.LoadData<CollaborationModel, dynamic>(sql, new { UPID = UPID });
        }

        public Task InsertCollaboration(CollaborationModel member)
        {
            string sql = @"insert into dbo.Collaboration (UPID,Id)
                           values (@UPID,@Id)";
            return _db.SaveData(sql, member);
        }
    }
}
