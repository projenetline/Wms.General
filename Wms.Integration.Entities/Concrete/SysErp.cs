using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysErp:IBaseEntity
    {
        public SysErp()
        {
            SysErpFirms = new HashSet<SysErpFirm>();
            SysErpIntegrations = new HashSet<SysErpIntegration>();
            SysUsers = new HashSet<SysUser>();
        }

        public int Id { get; set; }
        public short ErpType { get; set; }
        public string Description { get; set; }
        public short ConnectionType { get; set; }
        public string EndpointUrl { get; set; }
        public string ApiUrl1 { get; set; }
        public string ApiUrl2 { get; set; }
        public string ApiUrl3 { get; set; }
        public int Port { get; set; }
        public int TimeOut { get; set; }
        public string Language { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirmNumber { get; set; }
        public short DbType { get; set; }
        public string DbName { get; set; }
        public string DbUserName { get; set; }
        public string DbPassword { get; set; }
        public int Lcnport { get; set; }
        public string LcnapiUrl { get; set; }
        public string Lcnversion { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<SysErpFirm> SysErpFirms { get; set; }
        public virtual ICollection<SysErpIntegration> SysErpIntegrations { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
