using System;
using System.Collections.Generic;

namespace INTEX2_Section4_Group3.Models;

public partial class Customer
{
    public int? CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? BirthDate { get; set; }

    public string? CountryOfResidence { get; set; }

    public string? Gender { get; set; }

    public double? Age { get; set; }
}
