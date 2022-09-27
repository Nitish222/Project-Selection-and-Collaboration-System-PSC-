using PSC_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PSC_System.Data
{
    public class ProfileData : IProfileData
    {
        private readonly ISqlDataAccess _db;

        public ProfileData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ProfileModel>> GetProfile()
        {
            string sql = "select * from dbo.Profiles";
            return _db.LoadData<ProfileModel, dynamic>(sql, new { });
        }

        public Task UpdateProfile(string Id, int Score)
        {
            string sql = "UPDATE dbo.Profiles set SkillScore = @Score WHERE Id = @Id";
            return _db.SaveData(sql, new { SkillScore = Score, Id = Id });
        }

        public Task InsertProfile(ProfileModel profile)
        {
            string sql = @"insert into dbo.Profiles (Id,Name,CID,FID,SkillScore)
                           values (@Id,@Name,@CID,@FID,@SkillScore)";
            return _db.SaveData(sql, profile);
        }
    }
}
