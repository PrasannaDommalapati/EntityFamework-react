using AutoMapper;
using RestApiDev.Library.Data.Entity;
using RestApiDev.Library.Models;

namespace RestApiDev.Library.Mapping
{
    public class ToPromotion : Profile
    {
        public ToPromotion()
        {
            CreateMap<PromotedItems, PromotionModel>()
                .ForMember(p => p.Name, m => m.MapFrom(e => e.Name))
                .ForMember(p => p.FinishDate, m => m.MapFrom(e => e.EndDate));
        }
    }
}
