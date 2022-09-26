// /********************************************************
//  *                                                       *
//  *   Copyright (C) Microsoft. All rights reserved.       *
//  *                                                       *
//  ********************************************************/

namespace Microsoft.Security.DevOps.Policy
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class PolicyFile
    {
        [DataMember(Name = "schemaVersion", IsRequired = false, EmitDefaultValue = false, Order = 1)]
        public string SchemaVersionSTring { get; set; }

        [DataMember(Name = "version", IsRequired = false, EmitDefaultValue = false, Order = 2)]
        public string VersionString { get; set; }

        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false, Order = 3)]
        public string Id { get; set; }

        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false, Order = 4)]
        public string Name { get; set; }

        [DataMember(Name = "description", IsRequired = false, EmitDefaultValue = false, Order = 5)]
        public string Description { get; set; }

        [DataMember(Name = "author", IsRequired = false, EmitDefaultValue = false, Order = 6)]
        public string Author { get; set; }

        [DataMember(Name = "contact", IsRequired = false, EmitDefaultValue = false, Order = 7)]
        public string Contact { get; set; }

        [DataMember(Name = "helpUrl", IsRequired = false, EmitDefaultValue = false, Order = 8)]
        public string HelpUrl { get; set; }

        [DataMember(Name = "defaults", IsRequired = false, EmitDefaultValue = false, Order = 20)]
        public object Defaults { get; set; }

        [DataMember(Name = "tools", IsRequired = false, EmitDefaultValue = false, Order = 30)]
        public Dictionary<string, PolicyTool> Tools { get; set; }

        [DataMember(Name = "alternativeToolNames", IsRequired = false, EmitDefaultValue = false, Order = 31)]
        public Dictionary<string, string> AlternativeToolNames { get; set; }

        [DataMember(Name = "rules", IsRequired = false, EmitDefaultValue = false, Order = 40)]
        public Dictionary<string, PolicyRule> Rules { get; set; }

        [DataMember(Name = "alternativeRuleIds", IsRequired = false, EmitDefaultValue = false, Order = 41)]
        public Dictionary<string, string> AlternativeRuleIds { get; set; }

        [DataMember(Name = "rulePatterns", IsRequired = false, EmitDefaultValue = false, Order = 50)]
        public Dictionary<string, PolicyRule> RulePatterns { get; set; }
    }
}
