using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysErpIntegration:IBaseEntity
    {
        public int Id { get; set; }
        public int ErpId { get; set; }
        public int ErpFirmId { get; set; }
        public short RecordType { get; set; }
        public int RecordId { get; set; }
        public short ErpRecordType { get; set; }
        public string ErpRecordTrCode { get; set; }
        public int? ErpRecordId { get; set; }
        public int? ErpRelatedTransId { get; set; }
        public int? ErpRelatedLineId { get; set; }
        public string ErpRecordCode { get; set; }
        public string ErpRecordParameters { get; set; }
        public int? ErpPeriodNumber { get; set; }
        public DateTime? ErpModifiedDate { get; set; }
        public short IsMasterRecord { get; set; }
        public short IntegrationStatus { get; set; }
        public DateTime? IntegrationDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysErp Erp { get; set; }
        public virtual SysErpFirm ErpFirm { get; set; }
    }
}
