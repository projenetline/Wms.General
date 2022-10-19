using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemTotalsView:IBaseEntity
    {
        public int ItemId { get; set; }
        public int WarehouseId { get; set; }
        public int? AddressId { get; set; }
        public decimal? ActualStock { get; set; }
    }
}
