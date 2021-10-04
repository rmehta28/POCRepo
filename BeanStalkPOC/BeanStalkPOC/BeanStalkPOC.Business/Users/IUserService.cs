using BeanStalkPOC.Data.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeanStalkPOC.Business.Users
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAsync();
        Task<UserDto> GetByIDAsync(long userId);

        string GenerateToken(GetUserInput input);
        bool ValidateToken(GetUserInput input);
    }
}
