// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for RestorePointType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestorePointType
    {
        [EnumMember(Value = "DISCRETE")]
        DISCRETE,
        [EnumMember(Value = "CONTINUOUS")]
        CONTINUOUS
    }
    internal static class RestorePointTypeEnumExtension
    {
        internal static string ToSerializedValue(this RestorePointType? value)  =>
            value == null ? null : ((RestorePointType)value).ToSerializedValue();

        internal static string ToSerializedValue(this RestorePointType value)
        {
            switch( value )
            {
                case RestorePointType.DISCRETE:
                    return "DISCRETE";
                case RestorePointType.CONTINUOUS:
                    return "CONTINUOUS";
            }
            return null;
        }

        internal static RestorePointType? ParseRestorePointType(this string value)
        {
            switch( value )
            {
                case "DISCRETE":
                    return RestorePointType.DISCRETE;
                case "CONTINUOUS":
                    return RestorePointType.CONTINUOUS;
            }
            return null;
        }
    }
}