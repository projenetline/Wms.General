using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class HttpLogger:IBaseEntity
    {
        public Guid Id { get; set; }    
        public DateTime CreatedDate { get; set; }
        public string FullUrl { get; set; }
        public string Body { get; set; }
        public string LocalIp { get; set; }
        public string RemoteIp { get; set; }
        public int LocalPort { get; set; }
        public int RemotePort { get; set; }
        public int ResponseStatu { get; set; }
        public string Response { get; set; }
    }
}
