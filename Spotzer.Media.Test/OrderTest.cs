using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Spotzer.Media.Application.Dtos;
using Spotzer.Media.Application.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Xunit;

namespace Spotzer.Media.Test
{
    public class OrderTest
    {
        [Fact]
        public void CreateOrder_True_WhenPartnerAOrdered()
        {
            var orderObject = OrderData("partnerA.json");
            var creator = new OrderCreator<PartnerA>(new PartnerA());
            var response = creator.CreateOrder(orderObject);
            var actualData = response.IsValid;
            Assert.True(actualData);

        }
        [Fact]
        public void CreateOrder_True_WhenPartnerBOrdered()
        {
            var orderObject = OrderData("partnerB.json");
            var creator = new OrderCreator<PartnerB>(new PartnerB());
            var response = creator.CreateOrder(orderObject);
            var actualData = response.IsValid;
            Assert.True(actualData);

        }
        [Fact]
        public void CreateOrder_True_WhenPartnerCOrdered()
        {
            var orderObject = OrderData("partnerC.json");
            var creator = new OrderCreator<PartnerC>(new PartnerC());
            var response = creator.CreateOrder(orderObject);
            var actualData = response.IsValid;
            Assert.True(actualData);
        }
        [Fact]
        public void CreateOrder_True_WhenPartnerDOrdered()
        {
            var orderObject = OrderData("partnerD.json");
            var creator = new OrderCreator<PartnerD>(new PartnerD());
            var response = creator.CreateOrder(orderObject);
            var actualData = response.IsValid;
            Assert.True(actualData);
        }

        private static JObject OrderData(string fileName)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
            var json = File.ReadAllText(filePath);
            return JObject.Parse(json);
        }
    }
}
