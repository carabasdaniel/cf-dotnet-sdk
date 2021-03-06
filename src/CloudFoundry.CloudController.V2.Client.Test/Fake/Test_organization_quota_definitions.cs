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
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class OrganizationQuotaDefinitionsEndpoint
{
        [TestMethod]
        public void ListAllOrganizationQuotaDefinitionsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""0aa4df86-b416-4254-8188-1b2d4a91a417"",
        ""url"": ""/v2/quota_definitions/0aa4df86-b416-4254-8188-1b2d4a91a417"",
        ""created_at"": ""2015-05-19T15:27:00+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 100,
        ""total_routes"": 1000,
        ""memory_limit"": 10240,
        ""trial_db_allowed"": false,
        ""instance_memory_limit"": -1
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.OrganizationQuotaDefinitions.ListAllOrganizationQuotaDefinitions().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("0aa4df86-b416-4254-8188-1b2d4a91a417", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/quota_definitions/0aa4df86-b416-4254-8188-1b2d4a91a417", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:00+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("default", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].NonBasicServicesAllowed), true);
                Assert.AreEqual("100", TestUtil.ToTestableString(obj[0].TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj[0].TotalRoutes), true);
                Assert.AreEqual("10240", TestUtil.ToTestableString(obj[0].MemoryLimit), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].TrialDbAllowed), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj[0].InstanceMemoryLimit), true);

            }
        }

        [TestMethod]
        public void DeleteOrganizationQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.OrganizationQuotaDefinitions.DeleteOrganizationQuotaDefinition(guid).Wait();

            }
        }

        [TestMethod]
        public void UpdateOrganizationQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4f39781b-729a-40f9-9eba-f6a7cf35ccf3"",
    ""url"": ""/v2/quota_definitions/4f39781b-729a-40f9-9eba-f6a7cf35ccf3"",
    ""created_at"": ""2015-05-19T15:27:02+00:00"",
    ""updated_at"": ""2015-05-19T15:27:02+00:00""
  },
  ""entity"": {
    ""name"": ""name-23"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateOrganizationQuotaDefinitionRequest value = new UpdateOrganizationQuotaDefinitionRequest();


                var obj = cfClient.OrganizationQuotaDefinitions.UpdateOrganizationQuotaDefinition(guid, value).Result;


                Assert.AreEqual("4f39781b-729a-40f9-9eba-f6a7cf35ccf3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/quota_definitions/4f39781b-729a-40f9-9eba-f6a7cf35ccf3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-23", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);

            }
        }

        [TestMethod]
        public void CreateOrganizationQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5172a7f1-fef1-4915-aeec-b101f458b420"",
    ""url"": ""/v2/quota_definitions/5172a7f1-fef1-4915-aeec-b101f458b420"",
    ""created_at"": ""2015-05-19T15:27:02+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 5,
    ""total_routes"": 10,
    ""memory_limit"": 5120,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": 10240
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateOrganizationQuotaDefinitionRequest value = new CreateOrganizationQuotaDefinitionRequest();


                var obj = cfClient.OrganizationQuotaDefinitions.CreateOrganizationQuotaDefinition(value).Result;


                Assert.AreEqual("5172a7f1-fef1-4915-aeec-b101f458b420", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/quota_definitions/5172a7f1-fef1-4915-aeec-b101f458b420", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("10", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
                Assert.AreEqual("10240", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);

            }
        }

        [TestMethod]
        public void RetrieveOrganizationQuotaDefinitionTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""7eaac0b2-8a8c-4c53-a298-de13838dc4ff"",
    ""url"": ""/v2/quota_definitions/7eaac0b2-8a8c-4c53-a298-de13838dc4ff"",
    ""created_at"": ""2015-05-19T15:27:02+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-21"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""trial_db_allowed"": false,
    ""instance_memory_limit"": -1
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.OrganizationQuotaDefinitions.RetrieveOrganizationQuotaDefinition(guid).Result;


                Assert.AreEqual("7eaac0b2-8a8c-4c53-a298-de13838dc4ff", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/quota_definitions/7eaac0b2-8a8c-4c53-a298-de13838dc4ff", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-21", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
                Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
                Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
                Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.TrialDbAllowed), true);
                Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);

            }
        }

    }
}