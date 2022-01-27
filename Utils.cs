using Discord;
using Discord.Webhook;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dampfstube
{
    
    class Utils
    {

        
        
        public static void startstopLog(string text, string username)
        {
            HTTP.Post("https://discord.com/api/webhooks/935928431118520360/ecPrbHkWftaKpJFeQ0YUA2b7WgZ_qqULddHwLa7PnhQc2ahduZUFkYKcAy3wV-feglqN", new System.Collections.Specialized.NameValueCollection()
            {

                {
                    "username",
                    username
                },
                {
                    "content",
                    text
                }
            });
        }

        public static void adminLog(string text, string username)
        {
            HTTP.Post("https://discord.com/api/webhooks/935904519315922964/2ygxHpoqq6vims-m9lSyJ2vkLTD0zlBNnMbfXxTRBzbd_SBfypDPf2azoIzVcU_BJwsH", new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    text
                }
            });
        }
        public static void vehLog(string text, string username)
        {
            HTTP.Post("https://discord.com/api/webhooks/935918581382799442/WKG62XS8D1Us0CXoRhKJTZ-nY8hez4pOw68xjMFmTy_T0LLDpjVB_gQVhiIkh96-1lm6", new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    username
                },
                {
                    "content",
                    text
                }
            });
        }

        
    }
}
