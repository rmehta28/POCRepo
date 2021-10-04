
namespace BeanStalkPOC.Data.User
{
    public class GetUserInput
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ValidationToken { get; set; }
    }
}
