﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senparc.Weixin.MP.AdvancedAPIs.Poi;
using Senparc.Weixin.MP.CommonAPIs;
using Senparc.Weixin.MP.Entities;
using Senparc.Weixin.MP.Test.CommonAPIs;

namespace Senparc.Weixin.MP.Test.AdvancedAPIs
{
    [TestClass]
    public class PoiTest : CommonApiTest
    {
        [TestMethod]
        public void UploadImageTest()
        {
            var accessToken = AccessTokenContainer.GetToken(_appId);

            string file = @"E:\1.jpg";

            var result = PoiApi.UploadImage(accessToken, file);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.errcode, (int)ReturnCode.请求成功);
        }
    }
}
