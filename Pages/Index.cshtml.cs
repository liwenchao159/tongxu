﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcoreapp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPost()
        {
            var formkeys = HttpContext.Request.Form.Keys;
            if (formkeys != null && formkeys.Any())
            {

            }
        }
    }
}
