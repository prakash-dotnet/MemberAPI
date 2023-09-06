using Member.Data.Models;
using Member.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Data.Repository
{
    public class MembersRepository : IMember
    {
        List<Members> members = new List<Members>
        {
            new Members{MemberId=1, FirstName="Siva", LastName="Krishna", Address="Kadapa" },
            new Members{MemberId=2, FirstName="Sudharshan", LastName="Reddy", Address="Karnool" },
            new Members{MemberId=3, FirstName="Spandana", LastName="Reddy", Address="Hyderabad" },
             
        };
        public List<Members> GetAllMember()
        {
            return members;
        }

        public Members GetMember(int id)
        {
            return members.FirstOrDefault(x => x.MemberId == id);
        }
    }
}
