using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysBlockingException:IBaseEntity
    {
        public int Id { get; set; }
        public int BlockingTypeId { get; set; }
        public int CustomSlipTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysBlockingType BlockingType { get; set; }
    }
}
