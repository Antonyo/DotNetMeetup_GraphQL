using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GrapQLSample.Common.Extensions
{
    public static class ListExtensions
    {
        public static bool FromJson<T>(this List<T> list, string fileName)
        {
            try
            {
                list = JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(fileName));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
