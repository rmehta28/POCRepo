using BeanStalkPOC.Core.BaseRepository;
using BeanStalkPOC.Core.Entities;

namespace BeanStalkPOC.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Members

        private ApplicationContext _dbContext;
        private BaseRepository<Student> _students;
        private BaseRepository<Grade> _grades;
        private BaseRepository<User> _users;

        #endregion

        #region Constructor

        public UnitOfWork(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Interface Implementations

        public IRepository<Student> Students
        {
            get
            {
                return _students ??
                (_students = new BaseRepository<Student>(_dbContext));
            }
        }

        public IRepository<Grade> Grades
        {
            get
            {
                return _grades ??
                (_grades = new BaseRepository<Grade>(_dbContext));
            }
        }

        public IRepository<User> Users
        {
            get
            {
                return _users ??
                (_users = new BaseRepository<User>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        #endregion
    }
}
