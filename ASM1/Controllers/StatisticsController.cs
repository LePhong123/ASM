﻿namespace ASM.Controllers;

using Microsoft.AspNetCore.Mvc;

public class StatisticsController : Controller
{
    public IActionResult Index()
    {
        return this.View();
    }
}