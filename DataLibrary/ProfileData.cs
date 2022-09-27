using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    class ProfileData
    {
        private readonly IDataAccess _db;

        public ProfileData(IDataAccess db)
        {
            _db = db;
        }

        /*public Task<List<ProfileModel>> GetProfile()
        {
            private String uid = @context.User.Identity.Id;
            //TODO: Complete the Querry 
            string sql = "SELECT * from dbo.profile WHERE uid = "$";
            return _db.LoadData<ProfileModel, dynamic>(

        }

        public */
    }
}
