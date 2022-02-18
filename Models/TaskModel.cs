using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day8.Models
{
    public class TaskModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]

        public int Id { get; set; }

        public string? Title { get; set; }
        
        public bool IsCompleted { get; set; }
    }
}