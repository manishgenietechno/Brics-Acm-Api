using AutoMapper;
using BRICS_Acm_Api.DTOs;
using BRICS_Acm_Api.HelperMethods;
using BRICS_Acm_Api.Services.Interface;
using DataService.DBModels;
using Newtonsoft.Json;

namespace BRICS_API_NEO.Services
{
    public class HdfcImplementation : IhdfcInterface
    {
        private readonly IConfiguration _configuration;
        private readonly BricsrecosystemContext _dbcontext;
        private readonly IMapper _mapper;

        public HdfcImplementation(IConfiguration configuration, BricsrecosystemContext dbcontext, IMapper mapper)
        {
            _configuration = configuration;
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<object> IcoreNotification(string request)
        {
            Log _log = new Log();
            Object result = null;
            _log.Requestid = Guid.NewGuid().ToString();
            _log.Plainbody = request;
            _log.Sourceapiid = StaticClass.GetApiId(1, "coreAlert");

            try
            {
                var response = JsonConvert.DeserializeObject<Root>(request);
                var alert = response.GenericCorporateAlertRequest.First();
                bool alertExists = _dbcontext.Hdfccorealertstagings.Any(x => x.Alertsequenceno == alert.AlertSequenceNo);

                if (!alertExists)
                {
                    result = CommonResponse.Success(alert.AlertSequenceNo);
                    var data = _mapper.Map<Hdfccorealertstaging>(alert);
                    data.Bankid = 1;
                    _dbcontext.Hdfccorealertstagings.Add(data);
                    await _dbcontext.SaveChangesAsync();
                }
                else
                {
                    result = CommonResponse.Error(alert.AlertSequenceNo);
                }
            }
            catch (Exception ex)
            {
                _log.Errorlog = $"{ex.Message}\n{ex.StackTrace}";
                result = _log.Errorlog;
            }

            _log.Response = result.ToString();
            StaticClass.Log(_log);
            return result;
        }
    }
}
