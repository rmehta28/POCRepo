using BeanStalkPOC.Core.BaseEntity.AuditedEntity;

namespace BeanStalkPOC.Core.BaseEntity
{
    public class BaseEntityInteger : FullAuditedEntity<int>
    {
        public bool IsActive { get; set; }
    }
}
