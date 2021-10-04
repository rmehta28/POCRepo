using BeanStalkPOC.Data.Student;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeanStalkPOC.Business.Students
{
    public interface IStudentService
    {
        /// <summary>
        /// Method to get list of students.
        /// </summary>
        /// <returns>List of StudentDto</returns>
        Task<List<StudentDto>> GetAsync();

        /// <summary>
        /// Method to get student object by primary key.
        /// </summary>
        /// <param name="studentId">primary key of student</param>
        /// <returns>StudentDto</returns>
        Task<StudentDto> GetByIDAsync(int studentId);
    }
}
