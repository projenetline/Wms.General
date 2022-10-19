using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class Logger:IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MethodName { get; set; }
        public string ProjectName { get; set; }
        public string Message1 { get; set; }
        public string Message2 { get; set; }
        public string Statu { get; set; }
    }
}
