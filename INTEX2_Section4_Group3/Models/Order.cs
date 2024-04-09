﻿using System;
using System.Collections.Generic;

namespace INTEX2_Section4_Group3.Models;

public partial class Order
{
    public string? TransactionId { get; set; }

    public double? CustomerId { get; set; }

    public string? Date { get; set; }

    public string? DayOfWeek { get; set; }

    public double? Time { get; set; }

    public string? EntryMode { get; set; }

    public double? Amount { get; set; }

    public string? TypeOfTransaction { get; set; }

    public string? CountryOfTransaction { get; set; }

    public string? ShippingAddress { get; set; }

    public string? Bank { get; set; }

    public string? TypeOfCard { get; set; }

    public double? Fraud { get; set; }
}
