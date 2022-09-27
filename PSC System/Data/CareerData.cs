using PSC_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public class CareerData : ICareerData
    {
        private readonly ISqlDataAccess _db;

        public CareerData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CareerModel>> GetCareer()
        {
            string sql = "select * from dbo.Careers";
            return _db.LoadData<CareerModel, dynamic>(sql, new { });
        }

        public Task<List<CareerChoiceJoinModel>> GetUserCareer(string Id)
        {
            string sql = "select dbo.Profiles.Id,dbo.Profiles.CID,dbo.Careers.CareerName from dbo.Profiles INNER JOIN dbo.Careers ON Profiles.CID = Careers.CID WHERE Id = @Id; ";
            return _db.LoadData<CareerChoiceJoinModel, dynamic>(sql, new { Id = Id });
        }

        public Task InsertCareer(CareerModel career)
        {
            string sql = @"insert into Careers (CID,CareerName)
                           values (@CID,@CareerName)";
            return _db.SaveData(sql, career);
        }

    }
}
