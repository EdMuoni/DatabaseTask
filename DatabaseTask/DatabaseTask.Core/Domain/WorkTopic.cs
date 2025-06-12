using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class WorkTopic
{
    [Key]
    public int Id { get; set; }

    public required string description { get; set; }
}
