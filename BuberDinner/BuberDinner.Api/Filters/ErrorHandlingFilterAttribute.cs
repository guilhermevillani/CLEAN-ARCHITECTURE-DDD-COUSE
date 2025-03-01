﻿using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var problemDetails = new ProblemDetails()
        {
            Title ="An unhandled exception occurred.FILTER!",
            Status = (int)HttpStatusCode.InternalServerError
            
            

        };
        
        context.Result = new ObjectResult(problemDetails);
        
        context.ExceptionHandled = true;
    }
}