using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class ObjectRent
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }

    [ForeignKey("DeviceId")]
    public required Devices Devices { get; set; }

    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
}
