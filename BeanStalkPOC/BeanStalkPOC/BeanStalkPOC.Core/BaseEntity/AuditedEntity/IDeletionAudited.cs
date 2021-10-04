using System;

namespace BeanStalkPOC.Core.BaseEntity.AuditedEntity
{
    public interface IDeletionAudited
    {
        bool IsDeleted { get; set; }
        long? DeleterUserId { get; set; }
        DateTime? DeletionTime { get; set; }
    }
}
