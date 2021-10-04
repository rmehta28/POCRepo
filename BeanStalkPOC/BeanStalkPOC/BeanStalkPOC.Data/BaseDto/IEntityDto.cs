
namespace BeanStalkPOC.Data.BaseDto
{
    public interface IEntityDto<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
