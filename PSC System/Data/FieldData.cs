using PSC_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public class FieldData : IFieldData
    {
        private readonly ISqlDataAccess _db;

        public FieldData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<FieldsModel>> GetField()
        {
            string sql = "select * from dbo.Fields";
            return _db.LoadData<FieldsModel, dynamic>(sql, new { });
        }

        public Task InsertField(FieldsModel field)
        {
            string sql = @"insert into dbo.Fields (FID,FieldName)
                           values (@FID,@FieldName)";
            return _db.SaveData(sql, field);
        }
    }
}
