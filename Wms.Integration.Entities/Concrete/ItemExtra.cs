using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemExtra:IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Skt { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
    }
}
