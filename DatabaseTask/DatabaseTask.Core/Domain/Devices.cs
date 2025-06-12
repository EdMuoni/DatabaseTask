using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain;

public class Devices
{
    [Key]
    public int Id { get; set; }

    public required string manufacturer { get; set; }
    public required string name { get; set; }
    public required string type { get; set; }
    public required string serialNumber { get; set; }
    public required string condition { get; set; }

}
