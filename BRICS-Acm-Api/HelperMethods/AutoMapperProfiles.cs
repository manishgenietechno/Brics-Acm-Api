using AutoMapper;
using BRICS_Acm_Api.DTOs;
using DataService.DBModels;

namespace BRICS_Acm_Api.HelperMethods
{

    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            // Map

            CreateMap<AlertNotificationDTOs, Hdfccorealertstaging>()
            .ForMember(dest => dest.Alertsequenceno, opt => opt.MapFrom(src => src.AlertSequenceNo))
            .ForMember(dest => dest.Accountnumber, opt => opt.MapFrom(src => src.AccountNumber))
            .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
            .ForMember(dest => dest.Mnemoniccode, opt => opt.MapFrom(src => src.MnemonicCode))
            .ForMember(dest => dest.Remitterifsc, opt => opt.MapFrom(src => src.RemitterIFSC))
            .ForMember(dest => dest.Userreferencenumber, opt => opt.MapFrom(src => src.UserReferenceNumber))
            .ForMember(dest => dest.Chequeno, opt => opt.MapFrom(src => src.ChequeNo))
            .ForMember(dest => dest.Transactiondescription, opt => opt.MapFrom(src => src.TransactionDescription))
            .ForMember(dest => dest.Remittername, opt => opt.MapFrom(src => src.RemitterName))
            .ForMember(dest => dest.Remitteraccount, opt => opt.MapFrom(src => src.RemitterAccount))
            .ForMember(dest => dest.Valuedate, opt => opt.MapFrom(src => src.ValueDate))
            .ForMember(dest => dest.Virtualaccount, opt => opt.MapFrom(src => src.VirtualAccount))
            .ForMember(dest => dest.Remitterbank, opt => opt.MapFrom(src => src.RemitterBank))
            .ForMember(dest => dest.Transactiondate, opt => opt.MapFrom(src => src.TransactionDate))
            .ForMember(dest => dest.Debitcredit, opt => opt.MapFrom(src => src.DebitCredit));
        }

    }
}
