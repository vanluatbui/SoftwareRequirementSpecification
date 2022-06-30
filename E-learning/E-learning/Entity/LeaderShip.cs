using System.ComponentModel.DataAnnotations;

namespace E_learning.Entity
{
    public class LeaderShip
    {
        [Key]
        public string ID_LeaderShip { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
         public string Phone { get; set; }
    }
}
