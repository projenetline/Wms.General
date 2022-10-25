using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.Loggers
{
    public class LoggerInfoDto:IBaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public string Statu { get; set; }
    }
}
