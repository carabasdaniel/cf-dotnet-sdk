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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServicesTest
    {


        [TestMethod]
        public void TestListAllServicesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""801486df-b4a4-44b0-82e0-92a1eaedf5ce"",
        ""url"": ""/v2/services/801486df-b4a4-44b0-82e0-92a1eaedf5ce"",
        ""created_at"": ""2015-05-19T15:27:18+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-71"",
        ""provider"": ""provider-62"",
        ""url"": ""https://foo.com/url-88"",
        ""description"": ""desc-161"",
        ""long_description"": null,
        ""version"": ""version-46"",
        ""info_url"": null,
        ""active"": true,
        ""bindable"": true,
        ""unique_id"": ""1ce5120a-2fad-41e7-8117-561a20a38aa4"",
        ""extra"": null,
        ""tags"": [

        ],
        ""requires"": [

        ],
        ""documentation_url"": null,
        ""service_broker_guid"": ""2e786df7-0102-46fb-a6f9-0840449f6652"",
        ""plan_updateable"": false,
        ""service_plans_url"": ""/v2/services/801486df-b4a4-44b0-82e0-92a1eaedf5ce/service_plans""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicesResponse> page = Utilities.DeserializePage<ListAllServicesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("801486df-b4a4-44b0-82e0-92a1eaedf5ce", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/801486df-b4a4-44b0-82e0-92a1eaedf5ce", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:18+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-71", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("provider-62", TestUtil.ToTestableString(page[0].Provider), true);
            Assert.AreEqual("https://foo.com/url-88", TestUtil.ToTestableString(page[0].Url), true);
            Assert.AreEqual("desc-161", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].LongDescription), true);
            Assert.AreEqual("version-46", TestUtil.ToTestableString(page[0].Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Bindable), true);
            Assert.AreEqual("1ce5120a-2fad-41e7-8117-561a20a38aa4", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DocumentationUrl), true);
            Assert.AreEqual("2e786df7-0102-46fb-a6f9-0840449f6652", TestUtil.ToTestableString(page[0].ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].PlanUpdateable), true);
            Assert.AreEqual("/v2/services/801486df-b4a4-44b0-82e0-92a1eaedf5ce/service_plans", TestUtil.ToTestableString(page[0].ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlansForServiceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3f365d47-a559-404c-9719-0838fda36fcc"",
        ""url"": ""/v2/service_plans/3f365d47-a559-404c-9719-0838fda36fcc"",
        ""created_at"": ""2015-05-19T15:27:18+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1575"",
        ""free"": false,
        ""description"": ""desc-160"",
        ""service_guid"": ""97a3d33d-b6d4-487f-88e0-3f7690517252"",
        ""extra"": null,
        ""unique_id"": ""f016bf77-de4a-4d07-9a85-93a137ac3254"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/97a3d33d-b6d4-487f-88e0-3f7690517252"",
        ""service_instances_url"": ""/v2/service_plans/3f365d47-a559-404c-9719-0838fda36fcc/service_instances""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlansForServiceResponse> page = Utilities.DeserializePage<ListAllServicePlansForServiceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("3f365d47-a559-404c-9719-0838fda36fcc", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/3f365d47-a559-404c-9719-0838fda36fcc", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:18+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1575", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Free), true);
            Assert.AreEqual("desc-160", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("97a3d33d-b6d4-487f-88e0-3f7690517252", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("f016bf77-de4a-4d07-9a85-93a137ac3254", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("/v2/services/97a3d33d-b6d4-487f-88e0-3f7690517252", TestUtil.ToTestableString(page[0].ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/3f365d47-a559-404c-9719-0838fda36fcc/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""7d280557-ae2d-45cc-bc50-54b681b56ea4"",
    ""url"": ""/v2/services/7d280557-ae2d-45cc-bc50-54b681b56ea4"",
    ""created_at"": ""2015-05-19T15:27:18+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""SomeMysqlService"",
    ""provider"": ""MySql Provider"",
    ""url"": ""http://myql.provider.com"",
    ""description"": ""Mysql stores things for you"",
    ""long_description"": null,
    ""version"": ""2.0"",
    ""info_url"": null,
    ""active"": false,
    ""bindable"": true,
    ""unique_id"": null,
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": null,
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/7d280557-ae2d-45cc-bc50-54b681b56ea4/service_plans""
  }
}";

            CreateServiceDeprecatedResponse obj = Utilities.DeserializeJson<CreateServiceDeprecatedResponse>(json);

            Assert.AreEqual("7d280557-ae2d-45cc-bc50-54b681b56ea4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/7d280557-ae2d-45cc-bc50-54b681b56ea4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:18+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("SomeMysqlService", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("MySql Provider", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("http://myql.provider.com", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("Mysql stores things for you", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("2.0", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/7d280557-ae2d-45cc-bc50-54b681b56ea4/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestUpdateServiceDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""48a724ff-5d4b-435a-87ef-a31dd9a764d2"",
    ""url"": ""/v2/services/48a724ff-5d4b-435a-87ef-a31dd9a764d2"",
    ""created_at"": ""2015-05-19T15:27:19+00:00"",
    ""updated_at"": ""2015-05-19T15:27:19+00:00""
  },
  ""entity"": {
    ""label"": ""SomeMysqlService"",
    ""provider"": ""MySql Provider"",
    ""url"": ""http://myql.provider.com"",
    ""description"": ""Mysql stores things for you"",
    ""long_description"": null,
    ""version"": ""2.0"",
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""faaeb3ea-4995-415f-9a36-bef876039b2c"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""92b7462e-d54d-450a-94bc-b6c4db395f3f"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/48a724ff-5d4b-435a-87ef-a31dd9a764d2/service_plans""
  }
}";

            UpdateServiceDeprecatedResponse obj = Utilities.DeserializeJson<UpdateServiceDeprecatedResponse>(json);

            Assert.AreEqual("48a724ff-5d4b-435a-87ef-a31dd9a764d2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/48a724ff-5d4b-435a-87ef-a31dd9a764d2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:19+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-05-19T15:27:19+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("SomeMysqlService", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("MySql Provider", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("http://myql.provider.com", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("Mysql stores things for you", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("2.0", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("faaeb3ea-4995-415f-9a36-bef876039b2c", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("92b7462e-d54d-450a-94bc-b6c4db395f3f", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/48a724ff-5d4b-435a-87ef-a31dd9a764d2/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""14023c43-4516-4440-a94f-4d5853fd12d9"",
    ""url"": ""/v2/services/14023c43-4516-4440-a94f-4d5853fd12d9"",
    ""created_at"": ""2015-05-19T15:27:18+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-72"",
    ""provider"": ""provider-63"",
    ""url"": ""https://foo.com/url-90"",
    ""description"": ""desc-162"",
    ""long_description"": null,
    ""version"": ""version-47"",
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""8c101fd1-fd48-4070-9172-0e7538836607"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""5f91dc04-a7e1-4add-afa6-fa65a42849c7"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/14023c43-4516-4440-a94f-4d5853fd12d9/service_plans""
  }
}";

            RetrieveServiceResponse obj = Utilities.DeserializeJson<RetrieveServiceResponse>(json);

            Assert.AreEqual("14023c43-4516-4440-a94f-4d5853fd12d9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/14023c43-4516-4440-a94f-4d5853fd12d9", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:18+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-72", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("provider-63", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("https://foo.com/url-90", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("desc-162", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("version-47", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("8c101fd1-fd48-4070-9172-0e7538836607", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("5f91dc04-a7e1-4add-afa6-fa65a42849c7", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/14023c43-4516-4440-a94f-4d5853fd12d9/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }
    }
}
