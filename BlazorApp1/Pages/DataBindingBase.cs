using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public class DataBindingBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";

        protected string Gender { get; set; } = "Male";

        public string Description { get; set; } = string.Empty;
    }
}
