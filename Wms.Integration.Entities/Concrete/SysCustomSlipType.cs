﻿using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomSlipType:IBaseEntity
    {
        public SysCustomSlipType()
        {
            Slips = new HashSet<Slip>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public short SlipType { get; set; }
        public short ErpIntegration { get; set; }
        public short ErpRecordType { get; set; }
        public string ErpRecordTrCode { get; set; }
        public short ErpSlipType { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
