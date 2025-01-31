using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Managemate.Models
{
    public class Task
    {

        [Key]
        [Required]
        public string TaskId { get; set; } /// TS-45654,  EM-ert454, AD-43436

        [Required]
        public string Name { get; set; }
        public STATUSENUM Status { get; set; }


        public string CreatedBy { get; set; }

        [ForeignKey("CreatedBy")]
        public User User { get; set; }
    }


    public enum STATUSENUM
    {
        Assigned, OnGoing, Complete, Reviewed
    }
}