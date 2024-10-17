using Newtonsoft.Json;

namespace BRICS_Acm_Api.DTOs
{
    public class AlertNotificationDTOs
    {
        [JsonProperty("Alert Sequence No")]
        public string AlertSequenceNo { get; set; }

        [JsonProperty("Account number")]
        public string AccountNumber { get; set; }

        [JsonProperty("Amount")]
        public string Amount { get; set; }

        [JsonProperty("Mnemonic Code")]
        public string MnemonicCode { get; set; }

        [JsonProperty("Remitter IFSC")]
        public string RemitterIFSC { get; set; }

        [JsonProperty("User Reference Number")]
        public string UserReferenceNumber { get; set; }

        [JsonProperty("Cheque No")]
        public string ChequeNo { get; set; }

        [JsonProperty("Transaction Description")]
        public string TransactionDescription { get; set; }

        [JsonProperty("Remitter Name")]
        public string RemitterName { get; set; }

        [JsonProperty("Remitter Account")]
        public string RemitterAccount { get; set; }

        [JsonProperty("Value Date")]
        public string ValueDate { get; set; }

        [JsonProperty("Virtual Account")]
        public string VirtualAccount { get; set; }

        [JsonProperty("Remitter Bank")]
        public string RemitterBank { get; set; }

        [JsonProperty("Transaction Date")]
        public string TransactionDate { get; set; }

        [JsonProperty("Debit Credit")]
        public string DebitCredit { get; set; }
    }

    public class GenericCorporateAlertResponse
    {
        public string ErrorCode { get; set; }

        public string ErrorMessage { get; set; }

        public string DomainReferenceNo { get; set; }
    }

    public class Root
    {
        public List<AlertNotificationDTOs> GenericCorporateAlertRequest { get; set; }
    }

}

