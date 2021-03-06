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
    public class ServicePlansEndpoint
{
        [TestMethod]
        public void UpdateServicePlanDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""bef1866c-7b3e-44cc-bfc9-aea9375f7d62"",
    ""url"": ""/v2/service_plans/bef1866c-7b3e-44cc-bfc9-aea9375f7d62"",
    ""created_at"": ""2015-05-19T15:27:03+00:00"",
    ""updated_at"": ""2015-05-19T15:27:03+00:00""
  },
  ""entity"": {
    ""name"": ""100mb"",
    ""free"": true,
    ""description"": ""Let's you put data in your database!"",
    ""service_guid"": ""718bd9cb-7309-481a-b930-8d09f9dff045"",
    ""extra"": null,
    ""unique_id"": ""54623a44-83a5-4b17-a4ac-2b01a1cc7033"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/718bd9cb-7309-481a-b930-8d09f9dff045"",
    ""service_instances_url"": ""/v2/service_plans/bef1866c-7b3e-44cc-bfc9-aea9375f7d62/service_instances""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                UpdateServicePlanDeprecatedRequest value = new UpdateServicePlanDeprecatedRequest();


                var obj = cfClient.ServicePlans.UpdateServicePlanDeprecated(value).Result;


                Assert.AreEqual("bef1866c-7b3e-44cc-bfc9-aea9375f7d62", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/bef1866c-7b3e-44cc-bfc9-aea9375f7d62", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("100mb", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Free), true);
                Assert.AreEqual("Let's you put data in your database!", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("718bd9cb-7309-481a-b930-8d09f9dff045", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("54623a44-83a5-4b17-a4ac-2b01a1cc7033", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("/v2/services/718bd9cb-7309-481a-b930-8d09f9dff045", TestUtil.ToTestableString(obj.ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/bef1866c-7b3e-44cc-bfc9-aea9375f7d62/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServicePlansTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServicePlans.DeleteServicePlans(guid).Wait();

            }
        }

        [TestMethod]
        public void CreateServicePlanDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""b94f63ef-5d0d-45f6-bb43-6bdd49d7ed18"",
    ""url"": ""/v2/service_plans/b94f63ef-5d0d-45f6-bb43-6bdd49d7ed18"",
    ""created_at"": ""2015-05-19T15:27:03+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""100mb"",
    ""free"": true,
    ""description"": ""Let's you put data in your database!"",
    ""service_guid"": ""ba0b0617-aaff-4953-8b45-dbdf861502d0"",
    ""extra"": null,
    ""unique_id"": ""0f05d666-2714-40fd-95ee-b252145ca55a"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/ba0b0617-aaff-4953-8b45-dbdf861502d0"",
    ""service_instances_url"": ""/v2/service_plans/b94f63ef-5d0d-45f6-bb43-6bdd49d7ed18/service_instances""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServicePlanDeprecatedRequest value = new CreateServicePlanDeprecatedRequest();


                var obj = cfClient.ServicePlans.CreateServicePlanDeprecated(value).Result;


                Assert.AreEqual("b94f63ef-5d0d-45f6-bb43-6bdd49d7ed18", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/b94f63ef-5d0d-45f6-bb43-6bdd49d7ed18", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("100mb", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Free), true);
                Assert.AreEqual("Let's you put data in your database!", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("ba0b0617-aaff-4953-8b45-dbdf861502d0", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("0f05d666-2714-40fd-95ee-b252145ca55a", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("/v2/services/ba0b0617-aaff-4953-8b45-dbdf861502d0", TestUtil.ToTestableString(obj.ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/b94f63ef-5d0d-45f6-bb43-6bdd49d7ed18/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceInstancesForServicePlanTest()
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
        ""guid"": ""178a875d-4808-404c-a205-299d261f93d6"",
        ""url"": ""/v2/service_instances/178a875d-4808-404c-a205-299d261f93d6"",
        ""created_at"": ""2015-05-19T15:27:03+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-49"",
        ""credentials"": {
          ""creds-key-71"": ""creds-val-71""
        },
        ""service_plan_guid"": ""755b26a0-3eca-4120-8f4b-25f2429e3aeb"",
        ""space_guid"": ""9b96bd79-6a39-4bbb-9712-42e50fc688b8"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""space_url"": ""/v2/spaces/9b96bd79-6a39-4bbb-9712-42e50fc688b8"",
        ""service_plan_url"": ""/v2/service_plans/755b26a0-3eca-4120-8f4b-25f2429e3aeb"",
        ""service_bindings_url"": ""/v2/service_instances/178a875d-4808-404c-a205-299d261f93d6/service_bindings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServicePlans.ListAllServiceInstancesForServicePlan(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("178a875d-4808-404c-a205-299d261f93d6", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/178a875d-4808-404c-a205-299d261f93d6", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-49", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("755b26a0-3eca-4120-8f4b-25f2429e3aeb", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("9b96bd79-6a39-4bbb-9712-42e50fc688b8", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("/v2/spaces/9b96bd79-6a39-4bbb-9712-42e50fc688b8", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/755b26a0-3eca-4120-8f4b-25f2429e3aeb", TestUtil.ToTestableString(obj[0].ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/178a875d-4808-404c-a205-299d261f93d6/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveServicePlanTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""98a2ccd0-bffe-4174-8630-e2cf79a58f1b"",
    ""url"": ""/v2/service_plans/98a2ccd0-bffe-4174-8630-e2cf79a58f1b"",
    ""created_at"": ""2015-05-19T15:27:03+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-54"",
    ""free"": false,
    ""description"": ""desc-13"",
    ""service_guid"": ""bc5fe9f1-b1c8-4bbf-a5c8-9349d451ea52"",
    ""extra"": null,
    ""unique_id"": ""f90b7bb0-7a80-42ed-bd16-459e9025ab08"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/bc5fe9f1-b1c8-4bbf-a5c8-9349d451ea52"",
    ""service_instances_url"": ""/v2/service_plans/98a2ccd0-bffe-4174-8630-e2cf79a58f1b/service_instances""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServicePlans.RetrieveServicePlan(guid).Result;


                Assert.AreEqual("98a2ccd0-bffe-4174-8630-e2cf79a58f1b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/98a2ccd0-bffe-4174-8630-e2cf79a58f1b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-54", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Free), true);
                Assert.AreEqual("desc-13", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("bc5fe9f1-b1c8-4bbf-a5c8-9349d451ea52", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("f90b7bb0-7a80-42ed-bd16-459e9025ab08", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("/v2/services/bc5fe9f1-b1c8-4bbf-a5c8-9349d451ea52", TestUtil.ToTestableString(obj.ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/98a2ccd0-bffe-4174-8630-e2cf79a58f1b/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServicePlansTest()
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
        ""guid"": ""4ae3ec7c-4eea-4dea-a83b-73ed15434e6b"",
        ""url"": ""/v2/service_plans/4ae3ec7c-4eea-4dea-a83b-73ed15434e6b"",
        ""created_at"": ""2015-05-19T15:27:03+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-53"",
        ""free"": false,
        ""description"": ""desc-11"",
        ""service_guid"": ""f7c95e40-0c88-496f-a3d0-c570fbc35923"",
        ""extra"": null,
        ""unique_id"": ""13f239c2-7f33-431a-98d3-902fc82e8730"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/f7c95e40-0c88-496f-a3d0-c570fbc35923"",
        ""service_instances_url"": ""/v2/service_plans/4ae3ec7c-4eea-4dea-a83b-73ed15434e6b/service_instances""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServicePlans.ListAllServicePlans().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("4ae3ec7c-4eea-4dea-a83b-73ed15434e6b", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/4ae3ec7c-4eea-4dea-a83b-73ed15434e6b", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:03+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-53", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Free), true);
                Assert.AreEqual("desc-11", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("f7c95e40-0c88-496f-a3d0-c570fbc35923", TestUtil.ToTestableString(obj[0].ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Extra), true);
                Assert.AreEqual("13f239c2-7f33-431a-98d3-902fc82e8730", TestUtil.ToTestableString(obj[0].UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Active), true);
                Assert.AreEqual("/v2/services/f7c95e40-0c88-496f-a3d0-c570fbc35923", TestUtil.ToTestableString(obj[0].ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/4ae3ec7c-4eea-4dea-a83b-73ed15434e6b/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);

            }
        }

    }
}