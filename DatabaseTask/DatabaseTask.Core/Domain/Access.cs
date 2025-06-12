using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain;

public class Access
{
    [Key]

    public int Id { get; set; }

    public required string description { get; set; }
}
