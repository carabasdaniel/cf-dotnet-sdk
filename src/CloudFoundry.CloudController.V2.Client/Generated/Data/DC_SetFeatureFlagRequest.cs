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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.FeatureFlagsEndpoint.SetFeatureFlag()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/236/feature_flags/set_a_feature_flag.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SetFeatureFlagRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractSetFeatureFlagRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.FeatureFlagsEndpoint.SetFeatureFlag()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/236/feature_flags/set_a_feature_flag.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSetFeatureFlagRequest
    {

        /// <summary> 
        /// <para>The state of the feature flag.</para>
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The custom error message for the feature flag.</para>
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage
        {
            get;
            set;
        }
    }
}