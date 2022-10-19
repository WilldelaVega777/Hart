//--------------------------------------------------------------------------
// Imports Section
//--------------------------------------------------------------------------
using System.Threading;
using AutoMapper;
using Hart.Entities;
using Hart.Entities.Dto;
using Hart.Entities.Models;


//--------------------------------------------------------------------------
// Namespace Section
//--------------------------------------------------------------------------
namespace Hart.Mappings
{
    public class MappingProfile : Profile
    {
        //------------------------------------------------------------------
        // Constructor Method Section
        //------------------------------------------------------------------
        public MappingProfile()
        {
            //--------------------------------------------
            // Company
            //--------------------------------------------
            this.CreateMap<Product, ProductResponse>()
                .ForMember(
                    product =>
                        product.Description,
                        opt => opt.MapFrom(
                            x => string.Join(' ', x.Description, ".")
                        )
                );
        }
    }
}
