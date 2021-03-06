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
    public class BuildpacksTest
    {


        [TestMethod]
        public void TestChangePositionOfBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c428eba4-dbc5-4034-bf21-5bdad5335d84"",
    ""url"": ""/v2/buildpacks/c428eba4-dbc5-4034-bf21-5bdad5335d84"",
    ""created_at"": ""2015-05-19T15:27:21+00:00"",
    ""updated_at"": ""2015-05-19T15:27:21+00:00""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 3,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-1689""
  }
}";

            ChangePositionOfBuildpackResponse obj = Utilities.DeserializeJson<ChangePositionOfBuildpackResponse>(json);

            Assert.AreEqual("c428eba4-dbc5-4034-bf21-5bdad5335d84", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/c428eba4-dbc5-4034-bf21-5bdad5335d84", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("3", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-1689", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestLockOrUnlockBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c41f5fe4-c689-4f46-9897-398bd9370a96"",
    ""url"": ""/v2/buildpacks/c41f5fe4-c689-4f46-9897-398bd9370a96"",
    ""created_at"": ""2015-05-19T15:27:21+00:00"",
    ""updated_at"": ""2015-05-19T15:27:21+00:00""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": true,
    ""filename"": ""name-1686""
  }
}";

            LockOrUnlockBuildpackResponse obj = Utilities.DeserializeJson<LockOrUnlockBuildpackResponse>(json);

            Assert.AreEqual("c41f5fe4-c689-4f46-9897-398bd9370a96", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/c41f5fe4-c689-4f46-9897-398bd9370a96", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-1686", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestEnableOrDisableBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""9c7095eb-f19e-4eb2-a986-f2e992dad864"",
    ""url"": ""/v2/buildpacks/9c7095eb-f19e-4eb2-a986-f2e992dad864"",
    ""created_at"": ""2015-05-19T15:27:21+00:00"",
    ""updated_at"": ""2015-05-19T15:27:21+00:00""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": false,
    ""locked"": false,
    ""filename"": ""name-1683""
  }
}";

            EnableOrDisableBuildpackResponse obj = Utilities.DeserializeJson<EnableOrDisableBuildpackResponse>(json);

            Assert.AreEqual("9c7095eb-f19e-4eb2-a986-f2e992dad864", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/9c7095eb-f19e-4eb2-a986-f2e992dad864", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-1683", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestRetrieveBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""093c5b2e-6615-416e-9be1-f016aa4d7125"",
    ""url"": ""/v2/buildpacks/093c5b2e-6615-416e-9be1-f016aa4d7125"",
    ""created_at"": ""2015-05-19T15:27:21+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-1674""
  }
}";

            RetrieveBuildpackResponse obj = Utilities.DeserializeJson<RetrieveBuildpackResponse>(json);

            Assert.AreEqual("093c5b2e-6615-416e-9be1-f016aa4d7125", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/093c5b2e-6615-416e-9be1-f016aa4d7125", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-1674", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestCreatesAdminBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d29311c2-7414-41d4-af4e-eece322d70fa"",
    ""url"": ""/v2/buildpacks/d29311c2-7414-41d4-af4e-eece322d70fa"",
    ""created_at"": ""2015-05-19T15:27:21+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""Golang_buildpack"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": null
  }
}";

            CreatesAdminBuildpackResponse obj = Utilities.DeserializeJson<CreatesAdminBuildpackResponse>(json);

            Assert.AreEqual("d29311c2-7414-41d4-af4e-eece322d70fa", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/d29311c2-7414-41d4-af4e-eece322d70fa", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("Golang_buildpack", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestListAllBuildpacksResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""3d77979f-718a-4ef6-92df-e53a874daf44"",
        ""url"": ""/v2/buildpacks/3d77979f-718a-4ef6-92df-e53a874daf44"",
        ""created_at"": ""2015-05-19T15:27:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_1"",
        ""position"": 1,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-1671""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""240cba63-3a6e-4d1b-b4bb-740e0c88c04b"",
        ""url"": ""/v2/buildpacks/240cba63-3a6e-4d1b-b4bb-740e0c88c04b"",
        ""created_at"": ""2015-05-19T15:27:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_2"",
        ""position"": 2,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-1672""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""bf30169e-1b7a-4625-9cdd-2f612798bd90"",
        ""url"": ""/v2/buildpacks/bf30169e-1b7a-4625-9cdd-2f612798bd90"",
        ""created_at"": ""2015-05-19T15:27:21+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_3"",
        ""position"": 3,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-1673""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllBuildpacksResponse> page = Utilities.DeserializePage<ListAllBuildpacksResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("3d77979f-718a-4ef6-92df-e53a874daf44", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/3d77979f-718a-4ef6-92df-e53a874daf44", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Locked), true);
            Assert.AreEqual("name-1671", TestUtil.ToTestableString(page[0].Filename), true);
            Assert.AreEqual("240cba63-3a6e-4d1b-b4bb-740e0c88c04b", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/240cba63-3a6e-4d1b-b4bb-740e0c88c04b", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_2", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("2", TestUtil.ToTestableString(page[1].Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[1].Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].Locked), true);
            Assert.AreEqual("name-1672", TestUtil.ToTestableString(page[1].Filename), true);
            Assert.AreEqual("bf30169e-1b7a-4625-9cdd-2f612798bd90", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/bf30169e-1b7a-4625-9cdd-2f612798bd90", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:21+00:00", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_3", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("3", TestUtil.ToTestableString(page[2].Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[2].Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].Locked), true);
            Assert.AreEqual("name-1673", TestUtil.ToTestableString(page[2].Filename), true);
        }
    }
}
