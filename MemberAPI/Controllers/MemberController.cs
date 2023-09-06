using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Member.Data.Models;
using Member.Data.Services;
using Member.Data.Repository;

namespace MemberAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private IMember members = new MembersRepository();

        [HttpGet("Get")]
        public ActionResult<IEnumerable<Members>> GetAllMembers()
        {
            return members.GetAllMember();
        }

        [HttpGet("GetById")]
        public ActionResult<Members> GetMemberById(int id)
        {
            return members.GetMember(id);
        }

       
    }
}
