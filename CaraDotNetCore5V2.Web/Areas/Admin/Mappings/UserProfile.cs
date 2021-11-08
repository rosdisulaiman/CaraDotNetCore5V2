using CaraDotNetCore5V2.Infrastructure.Identity.Models;
using CaraDotNetCore5V2.Web.Areas.Admin.Models;
using AutoMapper;

namespace CaraDotNetCore5V2.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}