﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain;

public class Address
{
    [Key]
    public int Id { get; set; }

    public string? PostalCode { get; set; }
    public int? ApartmentNumber { get; set; }
    public int? BuildingPartNumber { get; set; }
    public string? RouteName { get; set; }
    public string? CityDistrict { get; set; }
    public string? AdministrativeUnit { get; set; }
    public string? County { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
