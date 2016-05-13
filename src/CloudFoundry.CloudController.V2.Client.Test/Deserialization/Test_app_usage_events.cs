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
    public class AppUsageEventsTest
    {


        [TestMethod]
        public void TestRetrieveAppUsageEventResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3"",
    ""url"": ""/v2/app_usage_events/05753afe-c418-450c-9c7d-1e0b94c1349c"",
    ""created_at"": ""2016-05-05T14:15:03Z""
  },
  ""entity"": {
    ""state"": ""STARTED"",
    ""previous_state"": null,
    ""memory_in_mb_per_instance"": 564,
    ""previous_memory_in_mb_per_instance"": null,
    ""instance_count"": 1,
    ""previous_instance_count"": null,
    ""app_guid"": ""f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3"",
    ""app_name"": ""name-1541"",
    ""space_guid"": ""f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3"",
    ""space_name"": ""name-1542"",
    ""org_guid"": ""f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3"",
    ""buildpack_guid"": ""f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3"",
    ""buildpack_name"": ""name-1543"",
    ""package_state"": ""STAGED"",
    ""previous_package_state"": null,
    ""parent_app_guid"": null,
    ""parent_app_name"": null,
    ""process_type"": ""web"",
    ""task_name"": null,
    ""task_guid"": null
  }
}";

            RetrieveAppUsageEventResponse obj = Utilities.DeserializeJson<RetrieveAppUsageEventResponse>(json);

            Assert.AreEqual("f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/app_usage_events/05753afe-c418-450c-9c7d-1e0b94c1349c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:03Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("STARTED", TestUtil.ToTestableString(obj.State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousState), true);
            Assert.AreEqual("564", TestUtil.ToTestableString(obj.MemoryInMbPerInstance), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousMemoryInMbPerInstance), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.InstanceCount), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousInstanceCount), true);
            Assert.AreEqual("f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("name-1541", TestUtil.ToTestableString(obj.AppName), true);
            Assert.AreEqual("f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("name-1542", TestUtil.ToTestableString(obj.SpaceName), true);
            Assert.AreEqual("f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3", TestUtil.ToTestableString(obj.OrgGuid), true);
            Assert.AreEqual("f594d3c4-a1d1-4e23-bb1a-6c56529ad2f3", TestUtil.ToTestableString(obj.BuildpackGuid), true);
            Assert.AreEqual("name-1543", TestUtil.ToTestableString(obj.BuildpackName), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(obj.PackageState), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.PreviousPackageState), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ParentAppGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ParentAppName), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(obj.ProcessType), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.TaskName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.TaskGuid), true);
        }

        [TestMethod]
        public void TestListAllAppUsageEventsResponse()
        {
            string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/app_usage_events?after_guid=5f49db32-be8e-4a5d-8040-15501069ea81=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""eecd88be-62f3-4226-9626-9a134388f446"",
        ""url"": ""/v2/app_usage_events/4dc9279b-a4ea-4bf7-adaf-292e1836fc05"",
        ""created_at"": ""2016-05-05T14:15:03Z""
      },
      ""entity"": {
        ""state"": ""STARTED"",
        ""previous_state"": null,
        ""memory_in_mb_per_instance"": 564,
        ""previous_memory_in_mb_per_instance"": null,
        ""instance_count"": 1,
        ""previous_instance_count"": null,
        ""app_guid"": ""eecd88be-62f3-4226-9626-9a134388f446"",
        ""app_name"": ""name-1535"",
        ""space_guid"": ""eecd88be-62f3-4226-9626-9a134388f446"",
        ""space_name"": ""name-1536"",
        ""org_guid"": ""eecd88be-62f3-4226-9626-9a134388f446"",
        ""buildpack_guid"": ""eecd88be-62f3-4226-9626-9a134388f446"",
        ""buildpack_name"": ""name-1537"",
        ""package_state"": ""STAGED"",
        ""previous_package_state"": null,
        ""parent_app_guid"": null,
        ""parent_app_name"": null,
        ""process_type"": ""web"",
        ""task_name"": null,
        ""task_guid"": null
      }
    }
  ]
}";

            PagedResponseCollection<ListAllAppUsageEventsResponse> page = Utilities.DeserializePage<ListAllAppUsageEventsResponse>(json, null);

            Assert.AreEqual("2", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("2", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("/v2/app_usage_events?after_guid=5f49db32-be8e-4a5d-8040-15501069ea81=asc=2=1", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("eecd88be-62f3-4226-9626-9a134388f446", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/app_usage_events/4dc9279b-a4ea-4bf7-adaf-292e1836fc05", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:03Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("STARTED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].PreviousState), true);
            Assert.AreEqual("564", TestUtil.ToTestableString(page[0].MemoryInMbPerInstance), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].PreviousMemoryInMbPerInstance), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].InstanceCount), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].PreviousInstanceCount), true);
            Assert.AreEqual("eecd88be-62f3-4226-9626-9a134388f446", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("name-1535", TestUtil.ToTestableString(page[0].AppName), true);
            Assert.AreEqual("eecd88be-62f3-4226-9626-9a134388f446", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("name-1536", TestUtil.ToTestableString(page[0].SpaceName), true);
            Assert.AreEqual("eecd88be-62f3-4226-9626-9a134388f446", TestUtil.ToTestableString(page[0].OrgGuid), true);
            Assert.AreEqual("eecd88be-62f3-4226-9626-9a134388f446", TestUtil.ToTestableString(page[0].BuildpackGuid), true);
            Assert.AreEqual("name-1537", TestUtil.ToTestableString(page[0].BuildpackName), true);
            Assert.AreEqual("STAGED", TestUtil.ToTestableString(page[0].PackageState), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].PreviousPackageState), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].ParentAppGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].ParentAppName), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(page[0].ProcessType), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].TaskName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].TaskGuid), true);
        }
    }
}
