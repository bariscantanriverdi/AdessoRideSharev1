using AdessoRideShare.Repository.EntityModel.Concerete;
using AdessoRideShare.WebApi.Application.Command;
using AdessoRideShare.WebApi.Models;
using AutoMapper;

namespace AdessoRideShare.WebApi.AutoMapperProfiles
{
    public class Profiles :Profile
    {
        public Profiles()
        {
            CreateMap<TravelPlan, TravelPlanModel>().ReverseMap();
            CreateMap<City, CityModel>().ReverseMap();
            CreateMap<User,UserModel >().ReverseMap();
            CreateMap<AddUserTravelPlanCommand, TravelPlanUsers>().ReverseMap();
            CreateMap<TravelPlanUserModel, TravelPlanUsers>().ReverseMap();
            CreateMap<UpdateUserTravelPlanCommand, TravelPlanUsers>().ReverseMap();
            CreateMap<User, AddUserCommand>().ReverseMap();
        }
    }
}
