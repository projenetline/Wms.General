using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Entities.Dtos
{
    public class UserForLoginDto:IBaseDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
