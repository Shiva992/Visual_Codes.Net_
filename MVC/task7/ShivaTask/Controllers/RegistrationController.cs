using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShivaTask.Models;
namespace ShivaTask.Controllers
{
    public class RegistrationController : ApiController
    {
        StudentManagementEntities db = new StudentManagementEntities();

        [HttpPost]
        [Route("InsertData")]
        public void InsertData(Table_1 r)
        {
            db.Table_1.Add(r);
            db.SaveChanges();
        }
    }
}

