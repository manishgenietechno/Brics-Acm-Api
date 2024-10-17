namespace BRICS_Acm_Api.HelperMethods
{

    public class CommonResponse
    {
        public static object Success(string domainReferenceNo)
        {
            var jsonResponse = new
            {
                GenericCorporateAlertResponse = new
                {
                    errorCode = "0",
                    errorMessage = "Success",
                    domainReferenceNo = domainReferenceNo
                }
            };
            return jsonResponse;
        }

        public static object Error(string domainReferenceNo)
        {
            return new
            {
                GenericCorporateAlertResponse = new
                {
                    errorCode = "1",
                    errorMessage = "Technical Reject",
                    domainReferenceNo = domainReferenceNo
                }
            };
        }
    }
}
