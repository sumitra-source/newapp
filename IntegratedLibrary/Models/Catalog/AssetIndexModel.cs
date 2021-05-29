using System.Collections.Generic;

namespace IntegratedLibrary.Models.Catalog
{
    public class AssetIndexModel
    {
        public IEnumerable<AssetIndexListingModel> Assets { get; set; }
    }
}