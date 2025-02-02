﻿using Application.Services.Products.Commands.AddNewCategory;
using Application.Services.Products.Commands.AddNewProduct;
using Application.Services.Products.Queries.GetAllCategories;
using Application.Services.Products.Queries.GetCategories;
using Application.Services.Products.Queries.GetProductDetailForAdmin;
using Application.Services.Products.Queries.GetProductDetailForSite;
using Application.Services.Products.Queries.GetProductForAdmin;
using Application.Services.Products.Queries.GetProductForSite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.FacadPatterns
{
    public interface IProductFacad
    {
        AddNewCategoryService AddNewCategoryService { get; }
        IGetCategoriesService GetCategoriesService { get; }
        AddNewProductService AddNewProductService { get; }
        IGetAllCategoriesService GetAllCategoriesService { get; }
        /// <summary>
        /// دریافت لیست محصولات
        /// </summary>
        IGetProductForAdminService GetProductForAdminService { get; }
        IGetProductDetailForAdminService GetProductDetailForAdminService { get; }
        IGetProductForSiteService GetProductForSiteService { get; }
        IGetProductDetailForSiteService GetProductDetailForSiteService { get; }
    }
}
