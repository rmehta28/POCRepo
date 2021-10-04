using BeanStalkPOC.Core.BaseEntity;
using System;

namespace BeanStalkPOC.Core.Entities
{
    public class Student : BaseEntityInteger
    {
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }
}
