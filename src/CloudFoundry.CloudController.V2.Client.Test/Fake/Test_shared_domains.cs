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
    public class SharedDomainsEndpoint
{
        [TestMethod]
        public void FilterSharedDomainsByNameTest()
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
        ""guid"": ""e893db12-d8e7-49b6-8ba9-4d6437317035"",
        ""url"": ""/v2/shared_domains/e893db12-d8e7-49b6-8ba9-4d6437317035"",
        ""created_at"": ""2015-05-19T15:27:03+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""shared-domain.com""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.FilterSharedDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("e893db12-d8e7-49b6-8ba9-4d6437317035", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/e893db12-d8e7-49b6-8ba9-4d6437317035", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("shared-domain.com", TestUtil.ToTestableString(obj[0].Name), true);

            }
        }

        [TestMethod]
        public void CreateSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""3443c560-eb70-4fab-8c6a-8769688edf31"",
    ""url"": ""/v2/shared_domains/3443c560-eb70-4fab-8c6a-8769688edf31"",
    ""created_at"": ""2015-05-19T15:27:03+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSharedDomainRequest value = new CreateSharedDomainRequest();


                var obj = cfClient.SharedDomains.CreateSharedDomain(value).Result;


                Assert.AreEqual("3443c560-eb70-4fab-8c6a-8769688edf31", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/3443c560-eb70-4fab-8c6a-8769688edf31", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);

            }
        }

        [TestMethod]
        public void DeleteSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SharedDomains.DeleteSharedDomain(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllSharedDomainsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""ad290d09-347f-4c1a-9f82-214fb4a7e26d"",
        ""url"": ""/v2/shared_domains/ad290d09-347f-4c1a-9f82-214fb4a7e26d"",
        ""created_at"": ""2015-05-19T15:27:00+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""7a17bcd2-4f46-4dcd-bd7d-94243fc82451"",
        ""url"": ""/v2/shared_domains/7a17bcd2-4f46-4dcd-bd7d-94243fc82451"",
        ""created_at"": ""2015-05-19T15:27:00+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""57c60c71-1412-40e3-acfa-3945aa50e197"",
        ""url"": ""/v2/shared_domains/57c60c71-1412-40e3-acfa-3945aa50e197"",
        ""created_at"": ""2015-05-19T15:27:03+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-8.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ae8d6736-dcc7-4ff7-a474-00a348d979e8"",
        ""url"": ""/v2/shared_domains/ae8d6736-dcc7-4ff7-a474-00a348d979e8"",
        ""created_at"": ""2015-05-19T15:27:03+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-9.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""cd9b27b2-2bfd-4b2e-ba87-d8af281691fc"",
        ""url"": ""/v2/shared_domains/cd9b27b2-2bfd-4b2e-ba87-d8af281691fc"",
        ""created_at"": ""2015-05-19T15:27:03+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-10.example.com""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.ListAllSharedDomains().Result;

                Assert.AreEqual("5", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("ad290d09-347f-4c1a-9f82-214fb4a7e26d", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ad290d09-347f-4c1a-9f82-214fb4a7e26d", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:00+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("7a17bcd2-4f46-4dcd-bd7d-94243fc82451", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/7a17bcd2-4f46-4dcd-bd7d-94243fc82451", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:00+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("57c60c71-1412-40e3-acfa-3945aa50e197", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/57c60c71-1412-40e3-acfa-3945aa50e197", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-8.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("ae8d6736-dcc7-4ff7-a474-00a348d979e8", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ae8d6736-dcc7-4ff7-a474-00a348d979e8", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-9.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("cd9b27b2-2bfd-4b2e-ba87-d8af281691fc", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/cd9b27b2-2bfd-4b2e-ba87-d8af281691fc", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-10.example.com", TestUtil.ToTestableString(obj[4].Name), true);

            }
        }

        [TestMethod]
        public void RetrieveSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""ad290d09-347f-4c1a-9f82-214fb4a7e26d"",
    ""url"": ""/v2/shared_domains/ad290d09-347f-4c1a-9f82-214fb4a7e26d"",
    ""created_at"": ""2015-05-19T15:27:00+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""customer-app-domain1.com""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SharedDomains.RetrieveSharedDomain(guid).Result;


                Assert.AreEqual("ad290d09-347f-4c1a-9f82-214fb4a7e26d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ad290d09-347f-4c1a-9f82-214fb4a7e26d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:00+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj.Name), true);

            }
        }

    }
}