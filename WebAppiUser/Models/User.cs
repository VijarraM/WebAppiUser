namespace WebAppiUser.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string firstName { get; set; }
        public required string lastName { get; set; }
        public required string email { get; set; }
        public required string password { get; set; }
        public string rol { get; set; }
        public bool isActive { get; set; } = true;

    }
}
