using System.Text.Json.Serialization;

namespace BRICS_Acm_Api.Models
{

    public class HdfcCoreAlertRequest
    {
        [JsonPropertyName("Alert Sequence No")]
        public string AlertSequenceNo { get; set; }

        [JsonPropertyName("Account number")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("Amount")]
        public string Amount { get; set; }

        [JsonPropertyName("Mnemonic Code")]
        public string MnemonicCode { get; set; }

        [JsonPropertyName("Remitter IFSC")]
        public string RemitterIFSC { get; set; }

        [JsonPropertyName("User Reference Number")]
        public string UserReferenceNumber { get; set; }

        [JsonPropertyName("Cheque No")]
        public string ChequeNo { get; set; }

        [JsonPropertyName("Transaction Description")]
        public string TransactionDescription { get; set; }

        [JsonPropertyName("Remitter Name")]
        public string RemitterName { get; set; }

        [JsonPropertyName("Remitter Account")]
        public string RemitterAccount { get; set; }

        [JsonPropertyName("Value Date")]
        public string ValueDate { get; set; }

        [JsonPropertyName("Virtual Account")]
        public string VirtualAccount { get; set; }

        [JsonPropertyName("Remitter Bank")]
        public string RemitterBank { get; set; }

        [JsonPropertyName("Transaction Date")]
        public string TransactionDate { get; set; }

        [JsonPropertyName("Debit Credit")]
        public string DebitCredit { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("GenericCorporateAlertRequest")]
        public List<HdfcCoreAlertRequest> AlertRequests { get; set; }
    }
}
