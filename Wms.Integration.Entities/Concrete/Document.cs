using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Document:IBaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public short RecordType { get; set; }
        public int? RecordId { get; set; }
        public short DocumentType { get; set; }
        public short DocumentNumber { get; set; }
        public string MimeType { get; set; }
        public byte[] DocumentData { get; set; }
        public byte[] Thumbnail { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
