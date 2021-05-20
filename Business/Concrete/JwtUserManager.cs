using Business.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;

namespace Business.Concrete
{
    public partial class JwtUserManager : IJwtUserService
    {
        IJwtUserDal _jwtUserDal;

        public JwtUserManager(IJwtUserDal jwtUserDal)
        {
            _jwtUserDal = jwtUserDal;
        }
        public IResult Delete(JwtUser jwtUser)
        {
            _jwtUserDal.Delete(jwtUser);
            return new SuccessResult(Messages.UserDeleted);
        }

        public JwtUser GetByMail(string email)
        {
            return _jwtUserDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaim(JwtUser jwtUser)
        {
            return _jwtUserDal.GetClaims(jwtUser);
        }

        public IResult Update(JwtUser jwtUser)
        {
            _jwtUserDal.Update(jwtUser);
            return new SuccessResult(Messages.UserUpdated);
        }
        public IResult Add(JwtUser jwtUser)
        {
            _jwtUserDal.Add(jwtUser);
            return new SuccessResult(Messages.UserAdded);
        }
    }
}
