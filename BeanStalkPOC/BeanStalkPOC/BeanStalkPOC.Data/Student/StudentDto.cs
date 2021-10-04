using BeanStalkPOC.Data.BaseDto;
using BeanStalkPOC.Data.Grade;
using System;

namespace BeanStalkPOC.Data.Student
{
    public class StudentDto : EntityDto<int>
    {
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public GradeDto Grade { get; set; }
    }
}
