using DataService.DBModels;
using BRICS_Acm_Api.DTOs;
using BRICS_Acm_Api.Models;

namespace BRICS_Acm_Api.HelperMethods
{
    public class StaticClass
    {
        private static IConfiguration _configuration;
        public StaticClass()
        {

        }

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static ConfigurationModel GetConfigCreadential()
        {
            //get static data
            ConfigurationModel configurationModel = new ConfigurationModel();
            var iciciCreadential = _configuration.GetSection("uatHardcodeData");
            var balanceInquiryCreadential = _configuration.GetSection("iciciCreadential");
            configurationModel.SecreatKey = balanceInquiryCreadential["secreatKey"];

            return configurationModel;
        }

        public static byte[] ExtractIV(string encryptData)
        {
            byte[] encryptedData = Convert.FromBase64String(encryptData);
            byte[] iv = new byte[16];
            Array.Copy(encryptedData, 0, iv, 0, iv.Length);
            return iv;
        }

        public static void Log(Log log)
        {
            BricsrecosystemContext _dbContext = new BricsrecosystemContext();

            if (log != null)
            {
                var existingLog = _dbContext.Logs.Where(x => x.Requestid == log.Requestid).FirstOrDefault();

                if (existingLog == null)
                {
                    _dbContext.Logs.Add(log);
                }
                else
                {
                    existingLog.Encryptedbody = log.Encryptedbody;
                    existingLog.Plainbody = log.Plainbody;
                    existingLog.Response = log.Response;
                    existingLog.Errorlog = log.Errorlog;
                }
                _dbContext.SaveChanges();
            }
        }

        public static int GetApiId(int bankId, string apiName)
        {
            int apiId = 0;
            BricsrecosystemContext _dbContext = new BricsrecosystemContext();
            apiId = Convert.ToInt32(_dbContext.Apimasters.Where(x => x.Bankid == bankId && x.Apiname == apiName && x.Isactive == 1 && x.Isdeleted == 0).Select(y => y.Id).FirstOrDefault());
            return apiId;
        }

        public static int PutApiId(int bankId, string apiName)
        {
            int apiId = 1;
            BricsrecosystemContext _dbContext = new BricsrecosystemContext();
            apiId = Convert.ToInt32(_dbContext.Apimasters.Where(x => x.Bankid == bankId && x.Apiname == apiName && x.Isactive == 1 && x.Isdeleted == 0).Select(y => y.Id).FirstOrDefault());
            return apiId;

        }
    }
}
