using BeanStalkPOC.Data.BaseDto;
using System;

namespace BeanStalkPOC.Data.User
{
    public class UserDto : EntityDto<long>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
