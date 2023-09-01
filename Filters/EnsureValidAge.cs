using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MoviesApp.Filters
{
    public class EnsureValidAge: Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var age = DateTime.Now.Year - DateTime.Parse(context.HttpContext.Request.Form["Birthday"]).Year;
            if (age < 7 || age > 99)
            {
                context.Result = new BadRequestResult();
            }
            
        }
        
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}