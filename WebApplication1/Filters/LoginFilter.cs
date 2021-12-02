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
            //Log writes to console after action is executed!
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
            //if user is admin, user logs in succesfully
            if ( _user == "admin" || _user == "superAdmin" )
            {
                return;
            }
            //if user is not admin, user cannot log in succesfully and redirected to error action
            else
            {
                //Console.WriteLine($"{_user} not authorized!");
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "Home", Action = "Error" }));
                return;
            }
        }
    }
}
