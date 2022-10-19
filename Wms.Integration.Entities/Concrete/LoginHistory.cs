using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class LoginHistory:IBaseEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Application { get; set; }
        public short IsSuccess { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
