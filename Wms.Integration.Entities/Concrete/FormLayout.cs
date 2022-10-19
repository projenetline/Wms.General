using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class FormLayout:IBaseEntity
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public int? FormId { get; set; }
        public int? ComponentId { get; set; }
        public short LayoutType { get; set; }
        public string Code { get; set; }
        public string Settings { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysRole Role { get; set; }
        public virtual SysUser User { get; set; }
    }
}
