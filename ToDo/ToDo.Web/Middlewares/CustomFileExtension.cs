using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ToDo.Web.Middlewares
{
    public static class CustomFileExtension
    {
        public static void UseCustomStaticFiles(this IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
    }
}
