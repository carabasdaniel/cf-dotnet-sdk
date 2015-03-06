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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SecurityGroupStagingDefaultsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSecurityGroupStagingDefaultsEndpoint
    {
        public SecurityGroupStagingDefaultsEndpoint(CloudFoundryClient client) : base()
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.DependencyLocator = client.DependencyLocator;
            this.UAAClient = client.UAAClient;
        }    
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{

    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSecurityGroupStagingDefaultsEndpoint : BaseEndpoint
    {

        /// <summary>
        /// Removing a Security Group as a default for staging
        /// </summary>
        public async Task RemovingSecurityGroupAsDefaultForStaging(Guid? guid)
        {
            string route = string.Format("/v2/config/staging_security_groups/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Delete;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Set a Security Group as a default for staging
        /// </summary>
        public async Task<SetSecurityGroupAsDefaultForStagingResponse> SetSecurityGroupAsDefaultForStaging(Guid? guid)
        {
            string route = string.Format("/v2/config/staging_security_groups/{0}", guid);
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Put;
            client.Headers.Add(await BuildAuthenticationHeader());
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<SetSecurityGroupAsDefaultForStagingResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Return the Security Groups used for staging
        /// </summary>
        public async Task<PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse>> ReturnSecurityGroupsUsedForStaging()
        {
            return await ReturnSecurityGroupsUsedForStaging(new RequestOptions());
        }

        public async Task<PagedResponseCollection<ReturnSecurityGroupsUsedForStagingResponse>> ReturnSecurityGroupsUsedForStaging(RequestOptions options)
        {
            string route = "/v2/config/staging_security_groups";
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);
            client.Method = HttpMethod.Get;
            client.Headers.Add(await BuildAuthenticationHeader());
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ReturnSecurityGroupsUsedForStagingResponse>(await response.ReadContentAsStringAsync());
        }
    }
}