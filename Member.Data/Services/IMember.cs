using Member.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Data.Services
{
    public interface IMember
    {
        List <Members> GetAllMember();
        Members GetMember(int id);
    }
}
