
using System.ComponentModel.DataAnnotations;

namespace Managemate.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        public string Agenda { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<MeetingParticipant> Participants { get; set; }
    }
}