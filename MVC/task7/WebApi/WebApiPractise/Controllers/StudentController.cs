using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using WebApiPractise.Models;
using System.Data.Entity;
using System.Web.Http;

namespace WebApiPractise.Controllers
{
    public class StudentController : ApiController
    {
        
        AssessmentTestEntities db = new AssessmentTestEntities();
        [HttpGet]
        [Route("DisplayData")]
        public List<UserProject>GetData()
        {
            return db.UserProjects.ToList();
        }
       
        [HttpPost]
        [Route("InsertData")]
        public void InsertData(UserProject std)
        {
            db.UserProjects.Add(std);
            db.SaveChanges();
            //return db.StudentApis.ToList();
        }


        [HttpGet]
        [Route("DeleteData/{id}")]
        public void DeleteData(int id)
        {
            var res = db.UserProjects.FirstOrDefault(x => x.ID == id);
            db.UserProjects.Remove(res);
            db.SaveChanges();
        }

        [HttpGet]
        [Route("SelectData/{id}")]
        public UserProject SelectData(int id)
        {
            var res = db.UserProjects.FirstOrDefault(x => x.ID == id);
            return res;
        }
      
         [HttpPut]
        [Route("UpdateData")]
        public void UpdateData(UserProject std)
        {
            var res = db.UserProjects.FirstOrDefault(x => x.ID == std.ID);
            res.UserName = std.UserName;
            res.Password = std.Password;
            res.ConfirmPassword = std.ConfirmPassword;
            res.emailID = std.emailID;
            res.City = std.City;
            db.SaveChanges();

        }
    }
}
