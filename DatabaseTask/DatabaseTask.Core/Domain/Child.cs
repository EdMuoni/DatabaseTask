using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain;

public class Child
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("EmployeeId")]
    public required Employee Employee { get; set; }
    public DateTime birthDate { get; set; }
    public required string firstName { get; set; }
    public required string lastName { get; set; }
}
