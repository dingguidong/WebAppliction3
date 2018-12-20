using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        public string messsage { get; set; }
        public void OnGet()
        {
            messsage = "1";
        }

        public void OnPostShow(string data)
        {
            messsage = data;
        }
    }
}
