using System;
using System.Collections.Generic;

namespace DataService.DBModels;

public partial class Apimaster
{
    public int Id { get; set; }

    public string? Apiname { get; set; }

    public string? Apiurl { get; set; }

    public string? Apitoken { get; set; }

    public string? Secretkey { get; set; }

    public int? Bankid { get; set; }

    public int? Isactive { get; set; }

    public int? Isdeleted { get; set; }
}
