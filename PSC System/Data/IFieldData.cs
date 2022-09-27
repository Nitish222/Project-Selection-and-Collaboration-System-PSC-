using PSC_System.Data.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PSC_System.Data
{
    public interface IFieldData
    {
        Task<List<FieldsModel>> GetField();
        Task InsertField(FieldsModel field);
    }
}