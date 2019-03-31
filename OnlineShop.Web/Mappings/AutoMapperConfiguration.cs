using AutoMapper;
using OnlineShop.Model.Models;
using OnlineShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {




            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCategory, PostCategoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<ProductCategory, ProductCategoryViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ProductTag, ProductTagViewModel>();

            //cfg.CreateMap<Footer, FooterViewModel>();
            //cfg.CreateMap<Slide, SlideViewModel>();
            //cfg.CreateMap<Page, PageViewModel>();
            //cfg.CreateMap<ContactDetail, ContactDetailViewModel>();
            //cfg.CreateMap<ApplicationGroup, ApplicationGroupViewModel>();
            //cfg.CreateMap<ApplicationRole, ApplicationRoleViewModel>();
            //cfg.CreateMap<ApplicationUser, ApplicationUserViewModel>();


        }


        //public static void Configure()
        //{

        //    Mapper.Initialize(cfg =>
        //    {
        //        cfg.CreateMap<Post, PostViewModel>();
        //        cfg.CreateMap<PostCategory, PostCategoryViewModel>();
        //        cfg.CreateMap<Tag, TagViewModel>();
        //        cfg.CreateMap<ProductCategory, ProductCategoryViewModel>();
        //        cfg.CreateMap<Product, ProductViewModel>();
        //        cfg.CreateMap<ProductTag, ProductTagViewModel>();
        //        //cfg.CreateMap<Footer, FooterViewModel>();
        //        //cfg.CreateMap<Slide, SlideViewModel>();
        //        //cfg.CreateMap<Page, PageViewModel>();
        //        //cfg.CreateMap<ContactDetail, ContactDetailViewModel>();
        //        //cfg.CreateMap<ApplicationGroup, ApplicationGroupViewModel>();
        //        //cfg.CreateMap<ApplicationRole, ApplicationRoleViewModel>();
        //        //cfg.CreateMap<ApplicationUser, ApplicationUserViewModel>();
        //    });
        //}
    }
}