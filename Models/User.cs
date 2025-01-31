using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Managemate.Models
{
    public class User
    {

        [Key]
        [Required]
        public string UserID { get; set; } /// TS-45654,  EM-ert454, AD-43436
        public UserType UserType { get; set; }
        public string Email { get; set; }
        public string[] Skill { get; set; }

        public DateTime JoinedOn { get; set; }
        public int MinWorkingHours { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }

    public enum UserType
    {
        TaskManager, Admin, Employee
    }
}