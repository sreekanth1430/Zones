using BuildingBlock.Zones.Model.CRMIL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BuildingBlock.Zones.CRMIL.Application.Common;

namespace BuildingBlock.Zones.CRMIL.Application.ApplicationBusiness.OrderRecall.Queries
{
    public class OrderDetailsDTO : IMapFrom <OrderDetail>
    {
       
        public int Id { get; set; }
        public string? Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrderDetail, OrderDetailsDTO>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.OrderId)).ReverseMap();

        }
    }
}
