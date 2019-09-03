﻿using AutoMapper;
using RestApiDev.Library.Data;
using RestApiDev.Library.Data.Entity;
using RestApiDev.Library.Models;
using System;

namespace RestApiDev.Manager
{
    public class Promotion : IPromotion
    {
        private readonly IDataContext DataContext;
        private readonly IMapper Mapper;

        public Promotion(IDataContext dataContext, IMapper mapper)
        {
            DataContext = dataContext.ValidateForNotNull();
            Mapper = mapper.ValidateForNotNull();
        }

        public void Create(PromotionModel promotion)
        {
            var item = Mapper.Map<PromotedItems>(promotion);

            DataContext.PromotedItems.Add(item);
            DataContext.Update();
        }
    }
}
