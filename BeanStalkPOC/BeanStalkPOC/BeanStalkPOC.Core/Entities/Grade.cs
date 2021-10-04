using BeanStalkPOC.Core.BaseEntity;
using System.Collections.Generic;

namespace BeanStalkPOC.Core.Entities
{
    public class Grade : BaseEntityInteger
    {
        public string GradeName { get; set; }
        public string Section { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
