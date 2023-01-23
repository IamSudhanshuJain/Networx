using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworxBusinessLayer.Interfaces;
using NetworxDataLayer;
using NetworxDataLayer.Entities;
using NetworxDataLayer.Interface;

namespace NetworxBusinessLayer
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRepository<AuthenticatedEntity> _authenticationRepository;
        public AuthenticationService(IRepository<AuthenticatedEntity> authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }
        public AuthenticatedEntity ValidateAuthenticationAndSetAccess(string username, string password)
        {
            AuthenticatedEntity AuthenticatedInformation = null;
            var usernamedata = new SqlParameter
            {
                ParameterName = "UserName",
                Value = username
            };
            var passworddata = new SqlParameter
            {
                ParameterName = "Password",
                Value = password
            };
            AuthenticatedInformation= _authenticationRepository.SQLQuery("exec usp_CheckAuthentication @username, @password", new[] { usernamedata, passworddata }).FirstOrDefault();
            return AuthenticatedInformation;
        }

    }
}
