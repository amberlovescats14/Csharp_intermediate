using System;

namespace Mosh_Part2
{
    internal class HttpCookie
    {
        public HttpCookie()
        {
        }

        public static implicit operator string(HttpCookie v)
        {
            throw new NotImplementedException();
        }
    }
}