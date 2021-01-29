using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_patch_RESTful.Models.Enums;

namespace E_patch_RESTful.Models
{
    public class Measurement
    {
        public long Id { get; set; }
        public State CurrentState { get; set; }
        public decimal MuscleValue1 { get; set; }
        public decimal MuscleValue2 { get; set; }

    }
}
