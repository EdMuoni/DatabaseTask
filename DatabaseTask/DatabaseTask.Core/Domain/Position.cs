using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class Position
{

    [Key]
    public int Id { get; set; }

    [ForeignKey("AccessId")]
    public required Access Access { get; set; }

    public DateTime positionCreatedDate { get; set; }
    public DateTime positionDisabledDate { get; set; }
}
