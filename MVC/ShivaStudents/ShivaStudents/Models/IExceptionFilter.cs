using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc.Filters;

namespace ShivaStudents.Models
{
    public interface IExceptionFilter
    {
        void OnException(ExceptionContext filterContext);
    }
}
