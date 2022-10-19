using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysLog:IBaseEntity
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public int ThreadId { get; set; }
        public string LogLevel { get; set; }
        public string Logger { get; set; }
        public string LogMessage { get; set; }
        public string Exception { get; set; }
        public string StackTrace { get; set; }
        public string Arguments { get; set; }
        public string CustomerName { get; set; }
        public string IpAddressPort { get; set; }
        public string MethodName { get; set; }
        public string TaskGuid { get; set; }
        public string ProcessGroup { get; set; }
        public string ProductVersion { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public int? WarehouseId { get; set; }
        public string RecordType { get; set; }
        public int? RecordId { get; set; }
        public int? ErpId { get; set; }
        public string ErpDescription { get; set; }
        public int? ErpFirmNumber { get; set; }
        public int? ErpPeriodBranch { get; set; }
        public string ErpRecordType { get; set; }
        public int? ErpRecordId { get; set; }
        public string ErpRecordParameters { get; set; }
    }
}
