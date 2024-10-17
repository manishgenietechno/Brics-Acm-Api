using System;
using System.Collections.Generic;

namespace DataService.DBModels;

public partial class Hdfccorealertstaging
{
    public int Id { get; set; }

    public int? Bankid { get; set; }

    public string? Alertsequenceno { get; set; }

    public string? Accountnumber { get; set; }

    public string? Amount { get; set; }

    public string? Mnemoniccode { get; set; }

    public string? Remitterifsc { get; set; }

    public string? Userreferencenumber { get; set; }

    public string? Chequeno { get; set; }

    public string? Transactiondescription { get; set; }

    public string? Remittername { get; set; }

    public string? Remitteraccount { get; set; }

    public string? Valuedate { get; set; }

    public string? Virtualaccount { get; set; }

    public string? Remitterbank { get; set; }

    public string? Transactiondate { get; set; }

    public string? Debitcredit { get; set; }

    public DateTime? Requestdatetime { get; set; }
}
