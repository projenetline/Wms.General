using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysBlockingType:IBaseEntity
    {
        public SysBlockingType()
        {
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            SysBlockingExceptions = new HashSet<SysBlockingException>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<SysBlockingException> SysBlockingExceptions { get; set; }
    }
}
