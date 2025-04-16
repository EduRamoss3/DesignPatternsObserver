

namespace DesignPatternsObserver.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        public User(int id, string userName)
        {
            Id = id;
            UserName = userName;
        }
    }
}
