using BeanStalkPOC.Business.Students;
using Moq;
using Xunit;

namespace BeanStalkPOC.Business_Test
{
    public class StudentService_Test
    {
        [Fact]
        public void GetStudent()
        {
            var mock = new Mock<IStudentService>();

            mock.Setup(p => p.GetByIDAsync(3));
            Assert.NotNull(mock.Object);
        }
    }
}
