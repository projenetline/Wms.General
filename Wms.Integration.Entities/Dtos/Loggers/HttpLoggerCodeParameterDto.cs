using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.Loggers
{
    public class HttpLoggerCodeParameterDto:IBaseDto
    {
        public DateTime? StartDate { get; set; }
        public string LocalIp { get; set; }
        public int LocalPort { get; set; }
        public string RemoteIp { get; set; }
        public int RemotePort { get; set; }
        public int ResponseStatu { get; set; }
        public bool Desc { get; set; }
    }
}
