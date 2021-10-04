using BeanStalkPOC.Core.BaseRepository;
using BeanStalkPOC.Core.Entities;

namespace BeanStalkPOC.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Student> Students { get; }
        IRepository<Grade> Grades { get; }
        IRepository<User> Users { get; }
        void Commit();
    }
}
