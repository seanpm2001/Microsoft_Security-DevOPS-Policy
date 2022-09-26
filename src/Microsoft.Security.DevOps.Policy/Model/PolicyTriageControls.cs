// /********************************************************
//  *                                                       *
//  *   Copyright (C) Microsoft. All rights reserved.       *
//  *                                                       *
//  ********************************************************/

namespace Microsoft.Security.DevOps.Policy
{
    using Microsoft.CodeAnalysis.Sarif;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class PolicyTriageControls
    {
        [DataMember(Name = "allow", IsRequired = false, EmitDefaultValue = false)]
        public bool Allow { get; set; } = true;

        public FailureLevel? RequireJustificationLevel { get; set; }

        [DataMember(Name = "requireJustificationLevel", IsRequired = false, EmitDefaultValue = false)]
        public string? RequireJustificationLevelString
        {
            get
            {
                return RequireJustificationLevel.ToString();
            }
            set
            {
                RequireJustificationLevel = (FailureLevel)Enum.Parse(typeof(FailureLevel), value);
            }
        }

        public FailureLevel? InvalidExpirationDateLevel { get; set; }

        [DataMember(Name = "invalidExpirationDateLevel", IsRequired = false, EmitDefaultValue = false)]
        public string? InvalidExpirationDateLevelString
        {
            get
            {
                return InvalidExpirationDateLevel?.ToString();
            }
            set
            {
                InvalidExpirationDateLevel = (FailureLevel)Enum.Parse(typeof(FailureLevel), value);
            }
        }

        public TimeSpan? ExpirationInDays { get; set; }

        [DataMember(Name = "expirationInDays", IsRequired = false, EmitDefaultValue = false)]
        public int? ExpirationInDaysInteger
        {
            get
            {
                return ExpirationInDays?.Days;
            }
            set
            {
                ExpirationInDays = TimeSpan.FromDays(Math.Max(value.HasValue ? value.Value : 0, 0));
            }
        }
    }
}
