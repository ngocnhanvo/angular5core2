using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angular5asp2.Models;
namespace Angular5asp2.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class VNNController : Controller
    {
        aspnetcoreContext db;
        public VNNController(aspnetcoreContext _db)
        {
            db = _db;
        }

        [HttpGet("[action]")]
        public IEnumerable<AdUser> AllUser()
        {
            return db.AdUser;
        }

        [HttpPost("[action]")]
        public JsonResult AddUser([FromBody] dynamic obj)
        {
            var json = new { status = "0", mess = "Created sucessfully." };
            try
            {
                AdUser user = new AdUser
                {
                    AdUserId = PublicFunction.Newid(),
                    Usercode = obj.code_user,
                    Username = obj.name_user
                };
                db.AdUser.Add(user);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                json = new { status = "1", mess = ex.Message };
            }
            return Json(json);
        }
    }
}
