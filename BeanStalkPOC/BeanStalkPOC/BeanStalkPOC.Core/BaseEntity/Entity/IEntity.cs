
namespace BeanStalkPOC.Core.BaseEntity.Entity
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
