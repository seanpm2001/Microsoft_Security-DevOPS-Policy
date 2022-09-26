// /********************************************************
//  *                                                       *
//  *   Copyright (C) Microsoft. All rights reserved.       *
//  *                                                       *
//  ********************************************************/

namespace Microsoft.Security.DevOps.Policy
{
    using Microsoft.CodeAnalysis.Sarif;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public class PolicyControls
    {
        public FailureLevel Level { get; set; } = FailureLevel.None;


        [DataMember(Name = "level", IsRequired = false, EmitDefaultValue = false, Order = 10)]
        public string LevelString
        {
            get
            {
                return Level.ToString();
            }
            set
            {
                Level = (FailureLevel)Enum.Parse(typeof(FailureLevel), value);
            }
        }

        [DataMember(Name = "modifications", IsRequired = false, EmitDefaultValue = false, Order = 20)]
        public bool AllowModifications { get; set; } = true;

        [DataMember(Name = "triage", IsRequired = false, EmitDefaultValue = false, Order = 10)]
        public Dictionary<string, PolicyTriageControls> TriageSets { get; set; }
    }
}
