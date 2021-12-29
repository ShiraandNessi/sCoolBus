﻿using AutoMapper;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBus
{
    class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<StationOfRoute, StationRouteDTO>()
           .ForMember(des => des.Address, opts => opts.MapFrom(src => src.Station.Address))
           .ForMember(des => des.PointX, opts => opts.MapFrom(src => src.Station.PointX))
           .ForMember(des => des.PointY, opts => opts.MapFrom(src => src.Station.PointY))
           .ReverseMap();

           CreateMap<StationOfRoute, StationDriverDTO>()
          .ForMember(des => des.Address, opts => opts.MapFrom(src => src.Station.Address))
          .ForMember(des => des.PointX, opts => opts.MapFrom(src => src.Station.PointX))
          .ForMember(des => des.PointY, opts => opts.MapFrom(src => src.Station.PointY))
          .ForMember(des => des.DriverId, opts => opts.MapFrom(src => src.Route.DriverId))
          .ReverseMap();

        }
    }
}