using System;

namespace BeanStalkPOC.Core.BaseEntity.AuditedEntity
{
    public interface ICreationAudited
    {
        DateTime CreationTime { get; set; }
        long? CreatorUserId { get; set; }
    }
}
