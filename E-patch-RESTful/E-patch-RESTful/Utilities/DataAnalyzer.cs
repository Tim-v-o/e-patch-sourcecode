using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_patch_RESTful.Utilities
{
    public class DataAnalyzer
    {
        public async Task<object> Analyze(object data)
        {
            await AnalyzeData(data);
            return data;
        }

        private Task<object> AnalyzeData(object data)
        {
            return null;
        }
    }
}
