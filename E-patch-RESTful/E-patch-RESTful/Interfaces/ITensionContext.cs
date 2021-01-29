using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_patch_RESTful.Models;

namespace E_patch_RESTful.Interfaces
{
    public interface ITensionContext
    {
        Measurement AddMeasurement(Measurement measurement);
    }
}
