using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class HealthCheck
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }
    public DateTime lastcheckDate { get; set; }
    public DateTime nextcheckDate { get; set; }
    public bool isHealthy { get; set; }

}
