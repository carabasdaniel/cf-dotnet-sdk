//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class OrganizationsTest
    {

        [TestMethod]
        public void TestUpdateOrganizationRequest()
        {
            string json = @"{
  ""name"": ""New Organization Name"",
  ""quota_definition_guid"": ""253230db-a60d-41f0-b2fd-35321c2bcaaf""
}";

            UpdateOrganizationRequest request = new UpdateOrganizationRequest();

            request.Name = "New Organization Name";
            request.QuotaDefinitionGuid = new Guid("253230db-a60d-41f0-b2fd-35321c2bcaaf");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateOrganizationRequest()
        {
            string json = @"{
  ""name"": ""my-org-name"",
  ""quota_definition_guid"": ""1b87c3fe-e911-49d3-bdc0-7d58e5c7474d""
}";

            CreateOrganizationRequest request = new CreateOrganizationRequest();

            request.Name = "my-org-name";
            request.QuotaDefinitionGuid = new Guid("1b87c3fe-e911-49d3-bdc0-7d58e5c7474d");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
