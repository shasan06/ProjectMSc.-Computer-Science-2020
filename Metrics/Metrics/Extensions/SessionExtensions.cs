using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            var json = JsonConvert.SerializeObject(value);
            var bytes = Encoding.UTF8.GetBytes(json);
            session.Set(key, bytes);
        }

        public static T GetObject<T>(this ISession session, string key)
        {            
            var bytes = session.Get(key);
            var json = Encoding.UTF8.GetString(bytes);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
