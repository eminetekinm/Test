using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Categories;
using Test.Categories.Dtos;

namespace Test.Mapping
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            #region CategoryMapping 
            CreateMap<Category, CategoryDto>().ReverseMap();//reverseMap çift taraflı haberleştiriyor
            CreateMap<Category, CategoryAddDto>().ReverseMap();
            #endregion
           /* #region Product Mapping
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductAddDto>().ReverseMap();
            #endregion*/
        }
    }
}
