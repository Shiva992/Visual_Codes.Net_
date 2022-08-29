using NuGet.Common;
using System.Web.Mvc;

namespace ShivaStudents.Models
{

    public class CustomExceptionHandlerFilter : FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is NullReferenceException)
            {
                filterContext.Result = new RedirectResult("Error.html");
                filterContext.ExceptionHandled = true;
            }
        }

    }
}
