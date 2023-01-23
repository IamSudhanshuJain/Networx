using NetworxDataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworxBusinessLayer.Interfaces
{
    public interface IAuthenticationService
    {
        AuthenticatedEntity ValidateAuthenticationAndSetAccess(string username, string password);


    }
}
