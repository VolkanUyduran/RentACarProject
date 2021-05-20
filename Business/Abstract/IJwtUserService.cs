using Core.Entities.Concrete;
using Core.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IJwtUserService
    {
        List<OperationClaim> GetClaim(JwtUser jwtUser);
        IResult Add(JwtUser jwtUser);
        IResult Delete(JwtUser jwtUser);
        IResult Update(JwtUser jwtUser);
        JwtUser GetByMail(string email);
    }
}
