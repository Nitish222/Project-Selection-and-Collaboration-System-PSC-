using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface ICareerData
    {
        Task<List<CareerModel>> GetCareer();
        Task<List<CareerChoiceJoinModel>> GetUserCareer(string Id);
        Task InsertCareer(CareerModel career);
    }
}