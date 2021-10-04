using AutoMapper;
using BeanStalkPOC.Business.Infrastructure;
using BeanStalkPOC.Core.Entities;
using BeanStalkPOC.Core.UnitOfWork;
using BeanStalkPOC.Data.User;
using BeanStalkPOC.Utility.Singleton;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeanStalkPOC.Business.Users
{
    public class UserService : IUserService
    {
        #region Members

        private readonly IUnitOfWork _unitOfWork;
        private readonly ISingleton _singleton;

        #endregion

        #region Constructor

        public UserService(IUnitOfWork unitOfWork, ISingleton singleton)
        {
            _unitOfWork = unitOfWork;
            _singleton = singleton;
        }

        #endregion

        #region Interface Implementations

        public async Task<UserDto> GetByIDAsync(long userId)
        {
            var result = await _unitOfWork.Users.GetByIDAsync(userId);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
            });

            IMapper mapperResponse = config.CreateMapper();
            var user = mapperResponse.Map<User, UserDto>(result);

            return user;
        }

        public async Task<List<UserDto>> GetAsync()
        {
            var result = await _unitOfWork.Users.GetAsync();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
            });

            IMapper mapperResponse = config.CreateMapper();
            var userList = mapperResponse.Map<List<User>, List<UserDto>>(result.ToList());
            return userList;
        }

        public string GenerateToken(GetUserInput input)
        {
            return TokenManager.GenerateToken(input.UserName);
        }

        public bool ValidateToken(GetUserInput input)
        {
            var userName = TokenManager.ValidateToken(input.ValidationToken);

            return userName != null ? userName.Equals(input.UserName) : false;
        }

        #endregion
    }
}
