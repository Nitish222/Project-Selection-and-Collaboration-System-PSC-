using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IProfileData
    {
        Task<List<ProfileModel>> GetProfile();
        Task InsertProfile(ProfileModel profile);
        Task UpdateProfile(string Id, int Score);
    }
}