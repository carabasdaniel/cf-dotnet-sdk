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
    public class ServiceInstancesEndpoint
{
        [TestMethod]
        public void UpdateServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""3c1d8405-af3d-48b3-b48a-712fd159ee44"",
    ""url"": ""/v2/service_instances/3c1d8405-af3d-48b3-b48a-712fd159ee44"",
    ""created_at"": ""2015-05-19T15:27:17+00:00"",
    ""updated_at"": ""2015-05-19T15:27:17+00:00""
  },
  ""entity"": {
    ""name"": ""name-1520"",
    ""credentials"": {
      ""creds-key-394"": ""creds-val-394""
    },
    ""service_plan_guid"": ""4a8af901-aed9-4a3f-bdcd-5e3c8c94e2b2"",
    ""space_guid"": ""197e1b67-5bba-471c-b9e8-dafdba5eb351"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""space_url"": ""/v2/spaces/197e1b67-5bba-471c-b9e8-dafdba5eb351"",
    ""service_plan_url"": ""/v2/service_plans/4a8af901-aed9-4a3f-bdcd-5e3c8c94e2b2"",
    ""service_bindings_url"": ""/v2/service_instances/3c1d8405-af3d-48b3-b48a-712fd159ee44/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateServiceInstanceRequest value = new UpdateServiceInstanceRequest();


                var obj = cfClient.ServiceInstances.UpdateServiceInstance(guid, value).Result;


                Assert.AreEqual("3c1d8405-af3d-48b3-b48a-712fd159ee44", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/3c1d8405-af3d-48b3-b48a-712fd159ee44", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:17+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-05-19T15:27:17+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1520", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("4a8af901-aed9-4a3f-bdcd-5e3c8c94e2b2", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("197e1b67-5bba-471c-b9e8-dafdba5eb351", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("/v2/spaces/197e1b67-5bba-471c-b9e8-dafdba5eb351", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/4a8af901-aed9-4a3f-bdcd-5e3c8c94e2b2", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/3c1d8405-af3d-48b3-b48a-712fd159ee44/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceInstancesTest()
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
        ""guid"": ""afd3323a-6949-49f8-9f71-45eaf7325202"",
        ""url"": ""/v2/service_instances/afd3323a-6949-49f8-9f71-45eaf7325202"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1494"",
        ""credentials"": {
          ""creds-key-382"": ""creds-val-382""
        },
        ""service_plan_guid"": ""86fbbc62-4fbb-4f5c-abc0-0d6e490945c0"",
        ""space_guid"": ""7f512e18-d2e0-484f-92f8-2278420a6099"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""space_url"": ""/v2/spaces/7f512e18-d2e0-484f-92f8-2278420a6099"",
        ""service_plan_url"": ""/v2/service_plans/86fbbc62-4fbb-4f5c-abc0-0d6e490945c0"",
        ""service_bindings_url"": ""/v2/service_instances/afd3323a-6949-49f8-9f71-45eaf7325202/service_bindings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceInstances.ListAllServiceInstances().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("afd3323a-6949-49f8-9f71-45eaf7325202", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/afd3323a-6949-49f8-9f71-45eaf7325202", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1494", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("86fbbc62-4fbb-4f5c-abc0-0d6e490945c0", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("7f512e18-d2e0-484f-92f8-2278420a6099", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("/v2/spaces/7f512e18-d2e0-484f-92f8-2278420a6099", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/86fbbc62-4fbb-4f5c-abc0-0d6e490945c0", TestUtil.ToTestableString(obj[0].ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/afd3323a-6949-49f8-9f71-45eaf7325202/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void CreateServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""85c93513-6daf-4c69-9293-aff838a6101c"",
    ""url"": ""/v2/service_instances/85c93513-6daf-4c69-9293-aff838a6101c"",
    ""created_at"": ""2015-05-19T15:27:17+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-service-instance"",
    ""credentials"": {
      ""creds-key-386"": ""creds-val-386""
    },
    ""service_plan_guid"": ""04c18b7a-e04d-4d15-89b3-82e8c0a8f3df"",
    ""space_guid"": ""4148ed17-5b5d-40e7-8c14-45cdd39ca752"",
    ""gateway_data"": ""CONFIGURATION"",
    ""dashboard_url"": ""http://dashboard.example.com"",
    ""type"": ""managed_service_instance"",
    ""space_url"": ""/v2/spaces/4148ed17-5b5d-40e7-8c14-45cdd39ca752"",
    ""service_plan_url"": ""/v2/service_plans/04c18b7a-e04d-4d15-89b3-82e8c0a8f3df"",
    ""service_bindings_url"": ""/v2/service_instances/85c93513-6daf-4c69-9293-aff838a6101c/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceInstanceRequest value = new CreateServiceInstanceRequest();


                var obj = cfClient.ServiceInstances.CreateServiceInstance(value).Result;


                Assert.AreEqual("85c93513-6daf-4c69-9293-aff838a6101c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/85c93513-6daf-4c69-9293-aff838a6101c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:17+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my-service-instance", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("04c18b7a-e04d-4d15-89b3-82e8c0a8f3df", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("4148ed17-5b5d-40e7-8c14-45cdd39ca752", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("CONFIGURATION", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("http://dashboard.example.com", TestUtil.ToTestableString(obj.DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("/v2/spaces/4148ed17-5b5d-40e7-8c14-45cdd39ca752", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/04c18b7a-e04d-4d15-89b3-82e8c0a8f3df", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/85c93513-6daf-4c69-9293-aff838a6101c/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void DeleteServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceInstances.DeleteServiceInstance(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBindingsForServiceInstanceTest()
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
        ""guid"": ""3f0462e7-179e-4e45-96c3-d43851c8d0fd"",
        ""url"": ""/v2/service_bindings/3f0462e7-179e-4e45-96c3-d43851c8d0fd"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""5eb2f940-fd3a-4837-98cc-9e65bc10a483"",
        ""service_instance_guid"": ""9e5d5afd-9211-4033-9002-6c290692b9cc"",
        ""credentials"": {
          ""creds-key-373"": ""creds-val-373""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/5eb2f940-fd3a-4837-98cc-9e65bc10a483"",
        ""service_instance_url"": ""/v2/service_instances/9e5d5afd-9211-4033-9002-6c290692b9cc""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceInstances.ListAllServiceBindingsForServiceInstance(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("3f0462e7-179e-4e45-96c3-d43851c8d0fd", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_bindings/3f0462e7-179e-4e45-96c3-d43851c8d0fd", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("5eb2f940-fd3a-4837-98cc-9e65bc10a483", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("9e5d5afd-9211-4033-9002-6c290692b9cc", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayName), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SyslogDrainUrl), true);
                Assert.AreEqual("/v2/apps/5eb2f940-fd3a-4837-98cc-9e65bc10a483", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/service_instances/9e5d5afd-9211-4033-9002-6c290692b9cc", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{""changed_count"":1}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? service_plan_guid = Guid.NewGuid();

                MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest value = new MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalRequest();


                var obj = cfClient.ServiceInstances.MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimental(service_plan_guid, value).Result;


                Assert.AreEqual("1", TestUtil.ToTestableString(obj.ChangedCount), true);

            }
        }

        [TestMethod]
        public void RetrieveServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""658714fa-2111-45a2-816f-a040bb8915a8"",
    ""url"": ""/v2/service_instances/658714fa-2111-45a2-816f-a040bb8915a8"",
    ""created_at"": ""2015-05-19T15:27:17+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1499"",
    ""credentials"": {
      ""creds-key-385"": ""creds-val-385""
    },
    ""service_plan_guid"": ""3182e9e0-20d5-45f4-abb3-3eb495aa82eb"",
    ""space_guid"": ""a359bea7-a177-4b62-bfec-2a5b2b847608"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""space_url"": ""/v2/spaces/a359bea7-a177-4b62-bfec-2a5b2b847608"",
    ""service_plan_url"": ""/v2/service_plans/3182e9e0-20d5-45f4-abb3-3eb495aa82eb"",
    ""service_bindings_url"": ""/v2/service_instances/658714fa-2111-45a2-816f-a040bb8915a8/service_bindings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceInstances.RetrieveServiceInstance(guid).Result;


                Assert.AreEqual("658714fa-2111-45a2-816f-a040bb8915a8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/658714fa-2111-45a2-816f-a040bb8915a8", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:17+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1499", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("3182e9e0-20d5-45f4-abb3-3eb495aa82eb", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("a359bea7-a177-4b62-bfec-2a5b2b847608", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
                Assert.AreEqual("/v2/spaces/a359bea7-a177-4b62-bfec-2a5b2b847608", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/3182e9e0-20d5-45f4-abb3-3eb495aa82eb", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/658714fa-2111-45a2-816f-a040bb8915a8/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrievingPermissionsOnServiceInstanceTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{""manage"":true}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceInstances.RetrievingPermissionsOnServiceInstance(guid).Result;


                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Manage), true);

            }
        }

    }
}