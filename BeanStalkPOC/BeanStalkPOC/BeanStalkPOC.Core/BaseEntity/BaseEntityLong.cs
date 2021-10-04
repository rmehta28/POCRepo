using BeanStalkPOC.Core.BaseEntity.AuditedEntity;

namespace BeanStalkPOC.Core.BaseEntity
{
    public class BaseEntityLong : FullAuditedEntity<long>
    {
        public bool IsActive { get; set; }
    }
}
