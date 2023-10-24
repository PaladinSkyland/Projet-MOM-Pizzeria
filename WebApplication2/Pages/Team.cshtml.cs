﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages;

public class TeamModel : PageModel
{
    private readonly ILogger<TeamModel> _logger;

    public TeamModel(ILogger<TeamModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}