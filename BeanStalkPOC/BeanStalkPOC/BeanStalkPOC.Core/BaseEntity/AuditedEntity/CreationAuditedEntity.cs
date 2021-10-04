using BeanStalkPOC.Core.BaseEntity.Entity;
using System;

namespace BeanStalkPOC.Core.BaseEntity.AuditedEntity
{
    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited
    {
        public virtual DateTime CreationTime { get; set; }
        public virtual long? CreatorUserId { get; set; }
    }
}
