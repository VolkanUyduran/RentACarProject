using Core.Entities.Concrete;
using Core.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<JwtUser> Register(JwtUserForRegisterDto jwtUserForRegisterDto, string password);
        IDataResult<JwtUser> Login(JwtUserForLoginDto jwtUserForLoginDto);
        IResult UserExist(string email);
        IDataResult<AccessToken> CreateAccessToken(JwtUser jwtUser);
    }
}
