using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Entities.Dtos
{
    public class UserForRegisterDto:IBaseDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
