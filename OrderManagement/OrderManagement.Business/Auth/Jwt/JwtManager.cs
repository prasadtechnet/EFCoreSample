using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Business.Auth.Jwt
{
    public class JwtManager
    {
        private readonly JwtConfigModel _jwtConfig;
        public JwtManager(JwtConfigModel jwtConfig)
        {
            _jwtConfig = jwtConfig;
        }


    }
}
