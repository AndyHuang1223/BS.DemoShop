﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoShop.Web.Models;
using DemoShop.Web.Services.Cms;

namespace DemoShop.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FakeCmsViewModelService _cmsViewModelService;

    public HomeController(ILogger<HomeController> logger, FakeCmsViewModelService cmsViewModelService)
    {
        _logger = logger;
        _cmsViewModelService = cmsViewModelService;
    }

    public async Task<IActionResult> Index()
    {
        var vm = await _cmsViewModelService.GetHomepageViewModel();
        return View(vm);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}