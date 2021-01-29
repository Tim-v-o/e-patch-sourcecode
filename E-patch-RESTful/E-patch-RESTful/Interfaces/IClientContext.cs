using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_patch_RESTful.Interfaces
{
    public interface IClientContext
    {
        Task<object> CreateWarmthPreference(object warmthObject);
        Task<object> GetWarmthPreference();
        Task<object> UpdateWarmthPreference(object warmthObject);
        Task<object> DeleteWarmthPreference(object warmthObject);

        Task<List<object>> GetPersonalData(object user);
    }
}
