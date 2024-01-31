using System.ComponentModel.DataAnnotations;

namespace TaskApiAssessment.Models
{
    public class Taskk
    {
        [Key]
        public int TaskId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreateBy { get; set; } = 1;
        public DateTime CreatedOn { get; set; }= DateTime.Now;
    }
}
