using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class VacationList
{

    [Key]
    public int Id { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }

    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public DateTime dateApproved { get; set; }
    public int totalDays { get; set; }
    public int vacationDaysUsed { get; set; }
    public int vacationDaysReamining { get; set; }
}
