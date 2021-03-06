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
    public class SecurityGroupsTest
    {


        [TestMethod]
        public void TestRetrieveSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";

            RetrieveSecurityGroupResponse obj = Utilities.DeserializeJson<RetrieveSecurityGroupResponse>(json);

            Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestAssociateSpaceWithSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";

            AssociateSpaceWithSecurityGroupResponse obj = Utilities.DeserializeJson<AssociateSpaceWithSecurityGroupResponse>(json);

            Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSpacesForSecurityGroupResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""9d13a7ab-0f36-4036-8caa-f47fc414d1cb"",
        ""url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb"",
        ""created_at"": ""2015-05-19T15:27:15+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1458"",
        ""organization_guid"": ""52242bb3-fa53-4279-9e78-ba91a4d484b6"",
        ""space_quota_definition_guid"": null,
        ""organization_url"": ""/v2/organizations/52242bb3-fa53-4279-9e78-ba91a4d484b6"",
        ""developers_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/developers"",
        ""managers_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/managers"",
        ""auditors_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/auditors"",
        ""apps_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/apps"",
        ""routes_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/routes"",
        ""domains_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/domains"",
        ""service_instances_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/service_instances"",
        ""app_events_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/app_events"",
        ""events_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/events"",
        ""security_groups_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForSecurityGroupResponse> page = Utilities.DeserializePage<ListAllSpacesForSecurityGroupResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("9d13a7ab-0f36-4036-8caa-f47fc414d1cb", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:15+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1458", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("52242bb3-fa53-4279-9e78-ba91a4d484b6", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("/v2/organizations/52242bb3-fa53-4279-9e78-ba91a4d484b6", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }

        [TestMethod]
        public void TestUpdateSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": ""2015-05-19T15:27:16+00:00""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";

            UpdateSecurityGroupResponse obj = Utilities.DeserializeJson<UpdateSecurityGroupResponse>(json);

            Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSecurityGroupsResponse()
        {
            string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
        ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
        ""created_at"": ""2015-05-19T15:27:04+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy1"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d9f82a70-e5a2-430e-b8b4-169a82d4dc03"",
        ""url"": ""/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03"",
        ""created_at"": ""2015-05-19T15:27:04+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy2"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2d659b5d-92c9-4893-9d3c-8e19979a4ffa"",
        ""url"": ""/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1461"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ac339892-bd4b-446f-9bb6-127d58764867"",
        ""url"": ""/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1462"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5476cbbf-96b1-4e8c-9776-83ef564f99c2"",
        ""url"": ""/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1463"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2/spaces""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSecurityGroupsResponse> page = Utilities.DeserializePage<ListAllSecurityGroupsResponse>(json, null);

            Assert.AreEqual("5", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
            Assert.AreEqual("d9f82a70-e5a2-430e-b8b4-169a82d4dc03", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy2", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03/spaces", TestUtil.ToTestableString(page[1].SpacesUrl), true);
            Assert.AreEqual("2d659b5d-92c9-4893-9d3c-8e19979a4ffa", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1461", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa/spaces", TestUtil.ToTestableString(page[2].SpacesUrl), true);
            Assert.AreEqual("ac339892-bd4b-446f-9bb6-127d58764867", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1462", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[3].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[3].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867/spaces", TestUtil.ToTestableString(page[3].SpacesUrl), true);
            Assert.AreEqual("5476cbbf-96b1-4e8c-9776-83ef564f99c2", TestUtil.ToTestableString(page[4].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2", TestUtil.ToTestableString(page[4].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(page[4].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[4].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1463", TestUtil.ToTestableString(page[4].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[4].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[4].StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2/spaces", TestUtil.ToTestableString(page[4].SpacesUrl), true);
        }

        [TestMethod]
        public void TestRemoveSpaceFromSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";

            RemoveSpaceFromSecurityGroupResponse obj = Utilities.DeserializeJson<RemoveSpaceFromSecurityGroupResponse>(json);

            Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestCreateSecurityGroupResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""088de609-e103-4228-8ae8-6956fbb77229"",
    ""url"": ""/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229"",
    ""created_at"": ""2015-05-19T15:27:16+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my_super_sec_group"",
    ""rules"": [
      {
        ""protocol"": ""icmp"",
        ""destination"": ""0.0.0.0/0"",
        ""type"": 0,
        ""code"": 1
      },
      {
        ""protocol"": ""tcp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""2048-3000"",
        ""log"": true
      },
      {
        ""protocol"": ""udp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""53, 5353""
      },
      {
        ""protocol"": ""all"",
        ""destination"": ""0.0.0.0/0""
      }
    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229/spaces""
  }
}";

            CreateSecurityGroupResponse obj = Utilities.DeserializeJson<CreateSecurityGroupResponse>(json);

            Assert.AreEqual("088de609-e103-4228-8ae8-6956fbb77229", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my_super_sec_group", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
            Assert.AreEqual("/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }
    }
}
