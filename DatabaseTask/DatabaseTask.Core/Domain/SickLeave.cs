using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class SickLeave
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }

    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public bool isActive { get; set; }

}
