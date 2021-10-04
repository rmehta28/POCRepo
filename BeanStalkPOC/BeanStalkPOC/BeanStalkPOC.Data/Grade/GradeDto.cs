using BeanStalkPOC.Data.BaseDto;
using BeanStalkPOC.Data.Student;
using System.Collections.Generic;

namespace BeanStalkPOC.Data.Grade
{
    public class GradeDto : EntityDto<int>
    {
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<StudentDto> Students { get; set; }
    }
}
