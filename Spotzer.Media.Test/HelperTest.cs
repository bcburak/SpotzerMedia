using Newtonsoft.Json.Linq;
using Spotzer.Media.Application.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Spotzer.Media.Test
{
    public class HelperTest
    {
        //check partner is valid?

        [Fact]
        public void GetJObjectValue_StringIsNullOrEmpty_WhenPartnerIsNullorEmpty()
        {
            string expectedStr = "{\"Id\":1,\"Name\":\"Lorem Ipsum\"}";
            var expectedJson = JObject.Parse(expectedStr);
            string actualResult = StaticHelper.GetJObjectValue(expectedJson,"partner");
            string expectedResult = string.Empty;

            Assert.Equal(expectedResult, actualResult);
            

        }
        [Fact]
        public void CheckPartnerFromList_False_WhenPartnerIsNotInList()
        {
            string partner = "X";
            bool actualResult = StaticHelper.CheckPartnerFromList(partner);
            bool expectedResult = false;
            Assert.Equal(expectedResult, actualResult);        

        }
    }
}
