using AutoMapper;
using RestApiDev.Library.Data;
using RestApiDev.Library.Data.Entity;
using RestApiDev.Library.Models;
using System;

namespace RestApiDev.Manager
{
    public class Promotion : IPromotion
    {
        private readonly DataContext DataContext;
        private readonly IMapper Mapper;

        public Promotion(DataContext dataContext, IMapper mapper)
        {
            DataContext = dataContext.ValidateForNotNull();
            Mapper = mapper;
        }

        public void Create(PromotionModel promotion)
        {
            var item = Mapper.Map<PromotedItems>(promotion);

            DataContext.PromotedItems.Add(item);
            DataContext.SaveChanges();
        }
    }
}
