﻿using Microsoft.AspNetCore.Mvc;
using System;

namespace api.Controllers.Treatments
{
    public static class Returns
    {
        public static OkObjectResult Success(string message) => new OkObjectResult(new
        {
            result = true,
            message
        });

        public static OkObjectResult Success(object content) => new OkObjectResult(new
        {
            result = true,
            content
        });

        public static OkObjectResult Success(object content, string message) => new OkObjectResult(new
        {
            result = true,
            content,
            message
        });

        public static BadRequestObjectResult Warning(string message) => new BadRequestObjectResult(new
        {
            result = false,
            message
        });

        public static BadRequestObjectResult Warning(string title, string message) => new BadRequestObjectResult(new
        {
            result = false,
            title,
            message
        });

        public static BadRequestObjectResult Error(Exception exception) => new BadRequestObjectResult(new
        {
            result = false,
            exception,
            message = exception.Message
        });
    }
}
