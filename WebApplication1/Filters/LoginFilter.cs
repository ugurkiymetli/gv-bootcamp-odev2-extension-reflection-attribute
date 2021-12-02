using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace WebApplication1.Filters
{
    public class LoginFilter : Attribute, IActionFilter
    {
        private readonly string _user;
        public LoginFilter( string user )
        {
            _user = user;
        }

        public void OnActionExecuted( ActionExecutedContext context )
        {
            if ( _user == "admin" || _user == "superAdmin" )
            {
                Console.WriteLine($"{_user} logged in!");
                return;
            }
            else
            {
                Console.WriteLine($"{_user} not authorized!");
                return;
            }
        }

        public void OnActionExecuting( ActionExecutingContext context )
        {
            if ( _user == "admin" || _user == "superAdmin" )
            {
                return;
            }
            else
            {
                //Console.WriteLine($"{_user} not authorized!");
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Error" }));
                return;
            }
        }
    }
}
