using BeanStalkPOC.Api.Infrastructure;
using BeanStalkPOC.Business.Students;
using BeanStalkPOC.Utility.Singleton;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BeanStalkPOC.Api.Controllers
{
    /// <summary>
    /// Student controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Members

        private readonly IStudentService _studentService;
        private readonly ISingleton _singleton;
        private readonly ILogger<StudentController> _logger;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes student controller.
        /// </summary>
        /// <param name="studentService">student service</param>
        /// <param name="singleton">singleton</param>
        /// <param name="logger">logger</param>
        public StudentController(IStudentService studentService, ISingleton singleton, ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _singleton = singleton;
            _logger = logger;
        }

        #endregion

        #region Actions

        /// <summary>
        /// Method to get list of students.
        /// </summary>
        [HttpGet]
        [Route("GetStudentsAsync")]
        public async Task<IActionResult> GetStudentsAsync()
        {
            try
            {
                var result = await _studentService.GetAsync();
                if (result == null)
                {
                    return ProcessResponse.Create(result, ApiResponseMessage.DataNotFound, HttpStatusCode.NotFound);
                }

                _logger.LogInformation("This is test");

                return ProcessResponse.Create(result, ApiResponseMessage.DataSuccess, HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return ProcessResponse.Create(ex, ex.Message, HttpStatusCode.InternalServerError);
            }
        }

        /// <summary>
        /// Method to get student object.
        /// </summary>
        /// <param name="studentId">student primary key.</param>
        [HttpGet]
        [Route("GetStudentByIDAsync")]
        public async Task<IActionResult> GetStudentByIDAsync(int studentId)
        {
            try
            {
                var result = await _studentService.GetByIDAsync(studentId);
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

        #endregion
    }
}