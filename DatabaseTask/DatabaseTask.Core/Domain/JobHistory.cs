using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class JobHistory
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }

    [ForeignKey("PositionId")]
    public required Position Position { get; set; }

    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
}
