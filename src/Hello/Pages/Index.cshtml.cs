// Licensed to Werner Strydom under one or more agreements.
// Werner Strydom licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hello.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}