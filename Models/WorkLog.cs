
using System.ComponentModel.DataAnnotations;

namespace Managemate.Models
{
    public class WorkLog
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public int TotalWorkingHours { get; set; }

        public virtual User Employee { get; set; }
    }
}