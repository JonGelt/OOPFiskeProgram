using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFiskeProgram
{
    internal class DTO
    {
        public List<SaltvandsFisk>? KødÆdeneSaltvandsFiskList { get; set; } = new List<SaltvandsFisk>();

        public List<SaltvandsFisk>? PlanteÆdeneSaltvandsFiskList { get; set; } = new List<SaltvandsFisk>();

        public List<FersksvandFisk>? KødÆdeneFerskvandsFiskList { get; set; } = new List<FersksvandFisk>();

        public List<FersksvandFisk>? PlanteÆdeneFerskvandsFiskList { get; set; } = new List<FersksvandFisk>();


    }
}
