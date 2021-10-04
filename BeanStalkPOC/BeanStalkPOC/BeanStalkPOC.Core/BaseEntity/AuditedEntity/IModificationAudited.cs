using System;

namespace BeanStalkPOC.Core.BaseEntity.AuditedEntity
{
    public interface IModificationAudited
    {
        DateTime? LastModificationTime { get; set; }
        long? LastModifierUserId { get; set; }
    }
}
