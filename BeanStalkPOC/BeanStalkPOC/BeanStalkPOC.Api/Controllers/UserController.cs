using BeanStalkPOC.Api.Infrastructure;
using BeanStalkPOC.Business.Users;
using BeanStalkPOC.Data.User;
using BeanStalkPOC.Utility.Singleton;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BeanStalkPOC.Api.Controllers
{
    /// <summary>
    /// User controller
    /// </summary>
    public class UserController : Controller
    {
        #region Members

        private readonly IUserService _userService;
        private readonly ISingleton _singleton;

        #endregion

        #region Constructor

        /// <summary>
        /// Initilizer user controller
        /// </summary>
        /// <param name="userService">user service injection</param>
        /// <param name="singleton">singleton service injection</param>
        public UserController(IUserService userService, ISingleton singleton)
        {
            _userService = userService;
            _singleton = singleton;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Method to get list of users.
        /// </summary>
        [HttpGet]
        [Route("GetUsersAsync")]
        public async Task<IActionResult> GetUsersAsync()
        {
            try
            {
                var result = await _userService.GetAsync();
                if (result == null)
                {
                    return ProcessResponse.Create(result, ApiResponseMessage.DataNotFound, HttpStatusCode.NotFound);
                }

                return ProcessResponse.Create(result, ApiResponseMessage.DataSuccess, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ProcessResponse.Create(ex, ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        /// Method to get user object.
        /// </summary>
        /// <param name="userId">user primary key.</param>
        [HttpGet]
        [Route("GetUserByIDAsync")]
        public async Task<IActionResult> GetUserByIDAsync(long userId)
        {
            try
            {
                var result = await _userService.GetByIDAsync(userId);
                if (result == null)
                {
                    return ProcessResponse.Create(result, ApiResponseMessage.DataNotFound, HttpStatusCode.NotFound);
                }

                return ProcessResponse.Create(result, ApiResponseMessage.DataSuccess, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ProcessResponse.Create(ex, ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        /// Method to generate token for user authentication.
        /// </summary>
        /// <param name="input">input object</param>
        [HttpGet]
        [Route("GenerateToken")]
        public IActionResult GenerateToken(GetUserInput input)
        {
            try
            {
                var result = _userService.GenerateToken(input);
                if (result == null)
                {
                    return ProcessResponse.Create(result, ApiResponseMessage.DataNotFound, HttpStatusCode.NotFound);
                }

                return ProcessResponse.Create(result, ApiResponseMessage.DataSuccess, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ProcessResponse.Create(ex, ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        /// Method to validate token.
        /// </summary>
        /// <param name="input">input object</param>
        [HttpGet]
        [Route("ValidateToken")]
        public IActionResult ValidateToken(GetUserInput input)
        {
            try
            {
                var result = _userService.ValidateToken(input);
                if (result)
                {
                    return ProcessResponse.Create(result, ApiResponseMessage.ValidToken, HttpStatusCode.OK);
                }

                return ProcessResponse.Create(result, ApiResponseMessage.InvalidToken, HttpStatusCode.NotFound);
            }
            catch (Exception ex)
            {
                return ProcessResponse.Create(ex, ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        #endregion
    }
}