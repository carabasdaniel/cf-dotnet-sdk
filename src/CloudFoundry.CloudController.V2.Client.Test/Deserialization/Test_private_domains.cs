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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class PrivateDomainsTest
    {


        [TestMethod]
        public void TestFilterPrivateDomainsByNameResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""62a3d815-b153-4916-aa64-e1cfc121d6f9"",
        ""url"": ""/v2/private_domains/62a3d815-b153-4916-aa64-e1cfc121d6f9"",
        ""created_at"": ""2015-03-19T13:19:37+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""6a680bdf-7b02-477b-827c-cc4a4db2c391"",
        ""owning_organization_url"": ""/v2/organizations/6a680bdf-7b02-477b-827c-cc4a4db2c391""
      }
    }
  ]
}";

            PagedResponseCollection<FilterPrivateDomainsByNameResponse> page = Utilities.DeserializePage<FilterPrivateDomainsByNameResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("62a3d815-b153-4916-aa64-e1cfc121d6f9", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/62a3d815-b153-4916-aa64-e1cfc121d6f9", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:37+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("6a680bdf-7b02-477b-827c-cc4a4db2c391", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/6a680bdf-7b02-477b-827c-cc4a4db2c391", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
        }

        [TestMethod]
        public void TestRetrievePrivateDomainResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d8679fc1-ba34-4687-9dd2-7d6fd59f413f"",
    ""url"": ""/v2/private_domains/d8679fc1-ba34-4687-9dd2-7d6fd59f413f"",
    ""created_at"": ""2015-03-19T13:19:36+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""aca19f37-15fa-437f-b0b5-db8bf4c00688"",
    ""owning_organization_url"": ""/v2/organizations/aca19f37-15fa-437f-b0b5-db8bf4c00688""
  }
}";

            RetrievePrivateDomainResponse obj = Utilities.DeserializeJson<RetrievePrivateDomainResponse>(json);

            Assert.AreEqual("d8679fc1-ba34-4687-9dd2-7d6fd59f413f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/d8679fc1-ba34-4687-9dd2-7d6fd59f413f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:36+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("aca19f37-15fa-437f-b0b5-db8bf4c00688", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/aca19f37-15fa-437f-b0b5-db8bf4c00688", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
        }

        [TestMethod]
        public void TestCreatePrivateDomainOwnedByGivenOrganizationResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""2ebf87d6-aa51-4d5b-b956-6d1a3ca0fa34"",
    ""url"": ""/v2/private_domains/2ebf87d6-aa51-4d5b-b956-6d1a3ca0fa34"",
    ""created_at"": ""2015-03-19T13:19:37+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""7b1bfeca-d0f1-4565-98e7-530737900f65"",
    ""owning_organization_url"": ""/v2/organizations/7b1bfeca-d0f1-4565-98e7-530737900f65""
  }
}";

            CreatePrivateDomainOwnedByGivenOrganizationResponse obj = Utilities.DeserializeJson<CreatePrivateDomainOwnedByGivenOrganizationResponse>(json);

            Assert.AreEqual("2ebf87d6-aa51-4d5b-b956-6d1a3ca0fa34", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/2ebf87d6-aa51-4d5b-b956-6d1a3ca0fa34", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:37+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("7b1bfeca-d0f1-4565-98e7-530737900f65", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/7b1bfeca-d0f1-4565-98e7-530737900f65", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
        }

        [TestMethod]
        public void TestListAllPrivateDomainsResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d8679fc1-ba34-4687-9dd2-7d6fd59f413f"",
        ""url"": ""/v2/private_domains/d8679fc1-ba34-4687-9dd2-7d6fd59f413f"",
        ""created_at"": ""2015-03-19T13:19:36+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""aca19f37-15fa-437f-b0b5-db8bf4c00688"",
        ""owning_organization_url"": ""/v2/organizations/aca19f37-15fa-437f-b0b5-db8bf4c00688""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""bed2b715-d1b6-4209-9117-4273754c7aba"",
        ""url"": ""/v2/private_domains/bed2b715-d1b6-4209-9117-4273754c7aba"",
        ""created_at"": ""2015-03-19T13:19:37+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-22.example.com"",
        ""owning_organization_guid"": ""610d0ae6-82a2-4a7f-88e6-9cea3856cff3"",
        ""owning_organization_url"": ""/v2/organizations/610d0ae6-82a2-4a7f-88e6-9cea3856cff3""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""67bc92ac-d1e6-44f8-aa1e-042f13519aad"",
        ""url"": ""/v2/private_domains/67bc92ac-d1e6-44f8-aa1e-042f13519aad"",
        ""created_at"": ""2015-03-19T13:19:37+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-23.example.com"",
        ""owning_organization_guid"": ""bc0254e5-8ed2-49f9-a28b-dc33955ec9aa"",
        ""owning_organization_url"": ""/v2/organizations/bc0254e5-8ed2-49f9-a28b-dc33955ec9aa""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""3e7ae495-27d6-4816-b01e-424c6c507cc1"",
        ""url"": ""/v2/private_domains/3e7ae495-27d6-4816-b01e-424c6c507cc1"",
        ""created_at"": ""2015-03-19T13:19:37+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-24.example.com"",
        ""owning_organization_guid"": ""9630e0de-4bdc-44b9-9fb1-41de1af66efb"",
        ""owning_organization_url"": ""/v2/organizations/9630e0de-4bdc-44b9-9fb1-41de1af66efb""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllPrivateDomainsResponse> page = Utilities.DeserializePage<ListAllPrivateDomainsResponse>(json);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("d8679fc1-ba34-4687-9dd2-7d6fd59f413f", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/d8679fc1-ba34-4687-9dd2-7d6fd59f413f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:36+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("aca19f37-15fa-437f-b0b5-db8bf4c00688", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/aca19f37-15fa-437f-b0b5-db8bf4c00688", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("bed2b715-d1b6-4209-9117-4273754c7aba", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/bed2b715-d1b6-4209-9117-4273754c7aba", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:37+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-22.example.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("610d0ae6-82a2-4a7f-88e6-9cea3856cff3", TestUtil.ToTestableString(page[1].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/610d0ae6-82a2-4a7f-88e6-9cea3856cff3", TestUtil.ToTestableString(page[1].OwningOrganizationUrl), true);
            Assert.AreEqual("67bc92ac-d1e6-44f8-aa1e-042f13519aad", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/67bc92ac-d1e6-44f8-aa1e-042f13519aad", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:37+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-23.example.com", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("bc0254e5-8ed2-49f9-a28b-dc33955ec9aa", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/bc0254e5-8ed2-49f9-a28b-dc33955ec9aa", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("3e7ae495-27d6-4816-b01e-424c6c507cc1", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/3e7ae495-27d6-4816-b01e-424c6c507cc1", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-03-19T13:19:37+00:00", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-24.example.com", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("9630e0de-4bdc-44b9-9fb1-41de1af66efb", TestUtil.ToTestableString(page[3].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/9630e0de-4bdc-44b9-9fb1-41de1af66efb", TestUtil.ToTestableString(page[3].OwningOrganizationUrl), true);
        }
    }
}
