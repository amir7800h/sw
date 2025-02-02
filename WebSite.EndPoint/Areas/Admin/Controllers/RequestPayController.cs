﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Fainances.Queries.GetRequestPayForAdmin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.EndPoint.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Operator, Admin")]
    public class RequestPayController : Controller
    {
        private readonly IGetRequestPayForAdminService _getRequestPayForAdminService;
        public RequestPayController(IGetRequestPayForAdminService getRequestPayForAdminService)
        {
            _getRequestPayForAdminService = getRequestPayForAdminService;
        }
        public IActionResult Index()
        {
            return View(_getRequestPayForAdminService.Execute().Data);
        }
    }
}
