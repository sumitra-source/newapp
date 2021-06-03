using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegratedLibrary.Models.Branch
{
    public class BranchIndexModel
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public IEnumerable<BranchDetailModel> Branches { get; set; }
    }
}
