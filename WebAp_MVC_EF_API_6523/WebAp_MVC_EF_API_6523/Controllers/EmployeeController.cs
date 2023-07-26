using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAp_MVC_EF_API_6523.Models;

namespace WebAp_MVC_EF_API_6523.Controllers
{
    public class EmployeeController : ApiController
    {
        DatabaseContext db = new DatabaseContext();

        [HttpPost]
        public IHttpActionResult empinsert(tblEmployee emp)
        {
            db.tblEmployees.Add(emp);
            db.SaveChanges();
            return Ok();// means everything is fine
        }

        public IHttpActionResult empget()
        {
             var data = db.tblEmployees.ToList();
            return Ok(data);// means everything is fine
        }
    }
}
