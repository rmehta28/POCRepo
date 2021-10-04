using AutoMapper;
using BeanStalkPOC.Core.Entities;
using BeanStalkPOC.Core.UnitOfWork;
using BeanStalkPOC.Data.Student;
using BeanStalkPOC.Utility.Singleton;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeanStalkPOC.Business.Students
{
    public class StudentService : IStudentService
    {
        #region Members

        private readonly IUnitOfWork _unitOfWork;
        private readonly ISingleton _singleton;

        #endregion

        #region Constructor

        public StudentService(IUnitOfWork unitOfWork, ISingleton singleton)
        {
            _unitOfWork = unitOfWork;
            _singleton = singleton;
        }

        #endregion

        #region Interface Implementations

        /// <summary>
        /// Method to get student object by primary key.
        /// </summary>
        /// <param name="studentId">primary key of student</param>
        /// <returns>StudentDto</returns>
        public async Task<StudentDto> GetByIDAsync(int studentId)
        {
            var result = await _unitOfWork.Students.GetByIDAsync(studentId);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDto>().ForMember(m => m.Grade, opt => opt.MapFrom(c => c.Grade));
            });

            IMapper mapperResponse = config.CreateMapper();
            var student = mapperResponse.Map<Student, StudentDto>(result);

            return student;
        }

        /// <summary>
        /// Method to get list of students.
        /// </summary>
        /// <returns>List of StudentDto</returns>
        public async Task<List<StudentDto>> GetAsync()
        {
            var result = await _unitOfWork.Students.GetAsync();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDto>().ForMember(m => m.Grade, opt => opt.MapFrom(c => c.Grade));
            });

            IMapper mapperResponse = config.CreateMapper();
            var studentList = mapperResponse.Map<List<Student>, List<StudentDto>>(result.ToList());
            return studentList;
        }

        #endregion
    }
}
