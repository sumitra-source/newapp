using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratedLibrary.Models.Branch
{
    public class BranchIndexModel
    {
        public IEnumerable<BranchDetailModel> Branches { get; set; }
    }
}
