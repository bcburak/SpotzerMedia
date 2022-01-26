using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotzer.Media.Application.Extensions
{
    public static class StaticHelper
    {

        public static string GetJObjectValue(JObject jsonValue, string key)
        {
            string withLowerKey = char.ToLower(key[0]) + key.Substring(1);
            foreach (KeyValuePair<string, JToken> keyValuePair in jsonValue)
            {
                if (key == keyValuePair.Key || withLowerKey == keyValuePair.Key)
                {
                    return keyValuePair.Value.ToString();
                }
            }
            return string.Empty;
        }

        public static bool CheckPartnerFromList(string partner)
        {
            var partnerList =  new List<string> { "A", "B", "C","D" };
            var partnerInOrderList = partnerList.Where(i => i.Contains(partner));

            var isPartnerInOrderList = partnerInOrderList.Count() > 0 ? true : false;

            return isPartnerInOrderList;


        }
    }
}
