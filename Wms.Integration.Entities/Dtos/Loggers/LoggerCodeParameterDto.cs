using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.Loggers
{
    public class LoggerCodeParameterDto:IBaseDto
    {
        public DateTime? StartDate { get; set;}
        public string MethodName { get; set; }
        public string ProjectName { get; set; }
        public string Statu { get; set; }
        public bool Desc { get; set; }
    }
}
