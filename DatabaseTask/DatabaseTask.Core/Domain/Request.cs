using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;
public class Request
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("workTopicId")]
    public required WorkTopic WorkTopic { get; set; }


    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }

    public DateTime createdDate { get; set; }
    public DateTime reviewedDate { get; set; }
    public string? status { get; set; }
    public string? description { get; set; }

}
