﻿using System.Runtime.Serialization;
using CloudFlare.Client.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CloudFlare.Client.Enumerators
{
    /// <summary>
    /// Represents DNS record types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DnsRecordType
    {
        [EnumMember(Value = "A")]
        A,

        [EnumMember(Value = "AAAA")]
        Aaaa,

        [EnumMember(Value = "CNAME")]
        Cname,

        [EnumMember(Value = "MX")]
        Mx,

        [EnumMember(Value = "LOC")]
        Loc,

        [DataTypeDnsRecord]
        [EnumMember(Value = "SRV")]
        Srv,

        [EnumMember(Value = "SPF")]
        Spf,

        [EnumMember(Value = "TXT")]
        Txt,

        [EnumMember(Value = "NS")]
        Ns,

        [EnumMember(Value = "CAA")]
        Caa,

        [EnumMember(Value = "PTR")]
        Ptr,

        [EnumMember(Value = "CERT")]
        Cert,

        [EnumMember(Value = "DNSKEY")]
        DnsKey,

        [EnumMember(Value = "DS")]
        Ds,

        [EnumMember(Value = "NAPTR")]
        NaPtr,

        [EnumMember(Value = "SMIMEA")]
        SMimeA,

        [EnumMember(Value = "SSHFP")]
        SshFp,

        [EnumMember(Value = "TLSA")]
        TlsA,

        [EnumMember(Value = "URI")]
        Uri
    }
}
