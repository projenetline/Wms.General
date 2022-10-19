using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ErpinvTotal:IBaseEntity
    {
        public int Id { get; set; }
        public int? Stockref { get; set; }
        public string Code { get; set; }
        public int? Variantref { get; set; }
        public string Variantcode { get; set; }
        public string Serilotn { get; set; }
        public string Expdate { get; set; }
        public string Lineexp { get; set; }
        public string Unitcode { get; set; }
        public decimal? Convfact1 { get; set; }
        public decimal? Convfact2 { get; set; }
        public int? Unitref { get; set; }
        public decimal? Onhand { get; set; }
    }
}
