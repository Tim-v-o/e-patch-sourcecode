using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using E_patch_RESTful.Interfaces;

namespace E_patch_RESTful.Context
{
    public class ClientContext : IClientContext
    {
        internal string DbConnection;

        public ClientContext(string dbConnection)
        {
            DbConnection = dbConnection;
        }

        public Task<object> CreateWarmthPreference(object warmthObject)
        {
            return null;
        }

        public Task<object> GetWarmthPreference()
        {
            return null;
        }

        public Task<object> UpdateWarmthPreference(object warmthObject)
        {
            return null;
        }

        public Task<object> DeleteWarmthPreference(object warmthObject)
        {
            return null;
        }

        public Task<List<object>> GetPersonalData(object user)
        {
            return null;
        }
    }
}
