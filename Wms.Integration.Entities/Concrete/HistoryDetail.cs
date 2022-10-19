using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class HistoryDetail:IBaseEntity
    {
        public int Id { get; set; }
        public int HistoryId { get; set; }
        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
