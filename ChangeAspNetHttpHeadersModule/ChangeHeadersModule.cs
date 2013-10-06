using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ChangeAspNetHttpHeadersModule
{
    public class ChangeHeadersModule : IHttpModule 
    {
        public void Dispose() {
            
        }

        public void Init(HttpApplication context) {
            context.PreSendRequestHeaders += context_PreSendRequestHeaders;
        }

        void context_PreSendRequestHeaders(object sender, EventArgs e) {
            HttpContext.Current.Response.Headers.Set("Server", "B-baka, it's not like I changed this header especially for you or anything!");
            HttpContext.Current.Response.Headers.Remove("x-aspnet-version");
            HttpContext.Current.Response.Headers.Remove("x-aspnetmvc-version");
        }
    }
}
