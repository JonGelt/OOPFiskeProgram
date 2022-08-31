using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFiskeProgram
{
    internal class DTO
    {
        public List<Fisk>? KødÆdeneSaltvandsFiskList { get; set; } = new List<Fisk>();

        public List<Fisk>? PlanteÆdeneSaltvandsFiskList { get; set; } = new List<Fisk>();

        public List<Fisk>? KødÆdeneFerskvandsFiskList { get; set; } = new List<Fisk>();

        public List<Fisk>? PlanteÆdeneFerskvandsFiskList { get; set; } = new List<Fisk>();


    }
}
