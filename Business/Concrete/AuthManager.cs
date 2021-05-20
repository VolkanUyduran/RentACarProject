using Business.Abstract;
using Core.Entities.Concrete;
using Core.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Core.Utilities.Security.Hashing;

namespace Business.Concrete
{

    public partial class JwtUserManager
    {
        public class AuthManager : IAuthService
        {
            private  IJwtUserService _jwtUserService;
            private ITokenHelper _tokenHelper;
            public AuthManager(IJwtUserService jwtUserService, ITokenHelper tokenHelper)
            {
                _tokenHelper = tokenHelper;
                _jwtUserService = jwtUserService;
            }
            public IDataResult<AccessToken> CreateAccessToken(JwtUser jwtUser)
            {
                var claims = _jwtUserService.GetClaim(jwtUser);
                var accessToken = _tokenHelper.CreateToken(jwtUser, claims);
                return new SuccesDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
            }

            public IDataResult<JwtUser> Login(JwtUserForLoginDto jwtUserForLoginDto)
            {
                var userToCheck = _jwtUserService.GetByMail(jwtUserForLoginDto.Email);
                if (userToCheck==null)
                {
                    return new ErrorDataResult<JwtUser>(Messages.UserNotFound);
                }
                if (!HashingHelper.VerifyPasswordHash(jwtUserForLoginDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
                {
                    return new ErrorDataResult<JwtUser>(Messages.PassswordError);
                }
                return new SuccesDataResult<JwtUser>(userToCheck, Messages.SuccesfullyLogin);
            }

            public IDataResult<JwtUser> Register(JwtUserForRegisterDto jwtUserForRegisterDto, string password)
            {
                byte[] passwordHash, passwordSalt;
                HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
                var jwtUser = new JwtUser
                {
                    Email = jwtUserForRegisterDto.Email,
                    FirstName=jwtUserForRegisterDto.FirstName,
                    LastName=jwtUserForRegisterDto.LastName,
                    PasswordHash=passwordHash,
                    PasswordSalt=passwordSalt,
                    Status=true
                };
                _jwtUserService.Add(jwtUser);
                return new SuccesDataResult<JwtUser>(jwtUser, Messages.UserRegistered);
            }

            public IResult UserExist(string email)
            {
                if (_jwtUserService.GetByMail(email)!=null)
                {
                    return new ErrorResult(Messages.UserAlreadyExist);
                }
                return new SuccessResult();
            }
        }
    }
}
