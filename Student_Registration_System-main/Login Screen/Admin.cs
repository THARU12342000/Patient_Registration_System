using System.ComponentModel.DataAnnotations;

namespace Student_Registration_System
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}