using System;
using System.Collections.Generic;

namespace DataService.DBModels;

public partial class Icicilog
{
    public string Requestid { get; set; } = null!;

    public string? Plainbody { get; set; }

    public string? Encryptedbody { get; set; }

    public string? Response { get; set; }

    public int? Sourceapiid { get; set; }

    public string? Errorlog { get; set; }

    public DateTime? Logdatetime { get; set; }
}
