﻿using Microsoft.AspNetCore.Mvc;

namespace Blog_Escola_Dotnet.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.Factory.StartNew(() =>
            {
                return View();
            });
        }
    }
}
