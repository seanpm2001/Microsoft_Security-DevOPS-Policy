// /********************************************************
//  *                                                       *
//  *   Copyright (C) Microsoft. All rights reserved.       *
//  *                                                       *
//  ********************************************************/

namespace Microsoft.Security.DevOps.Policy
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class PolicyTool
    {
        [DataMember(Name = "isRequired", IsRequired = false, EmitDefaultValue = false, Order = 10)]
        public bool IsRequired { get; set; }

        [DataMember(Name = "defaults", IsRequired = false, EmitDefaultValue = false, Order = 10)]
        public PolicyControls Defaults { get; set; }

        [DataMember(Name = "rules", IsRequired = false, EmitDefaultValue = false, Order = 20)]
        public Dictionary<string, PolicyRule> Rules { get; set; }

        [DataMember(Name = "versions", IsRequired = false, EmitDefaultValue = false, Order = 30)]
        public Dictionary<string, PolicyTool> Versions { get; set; }
    }
}
