using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain;
public class Hint
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("WorkTopicId")]
    public required WorkTopic WorkTopic { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }


    public DateTime createdDate { get; set; }
    public DateTime reviewedDate { get; set; }
    public required string description { get; set; }
}
