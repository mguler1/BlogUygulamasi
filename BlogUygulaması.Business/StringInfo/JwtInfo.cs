using System;
using System.Collections.Generic;
using System.Text;

namespace BlogUygulaması.Business.StringInfo
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:61994";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "muhammedmuhammed";
        public const double Expires = 40;
    }
}
