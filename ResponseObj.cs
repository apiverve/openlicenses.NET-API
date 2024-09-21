using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("domain_content")]
    public bool domaincontent { get; set; }

    [JsonProperty("domain_data")]
    public bool domaindata { get; set; }

    [JsonProperty("domain_software")]
    public bool domainsoftware { get; set; }

    [JsonProperty("legacy_ids")]
    public string[] legacyids { get; set; }

    [JsonProperty("license")]
    public string license { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("license_url")]
    public string licenseurl { get; set; }

    [JsonProperty("license_status")]
    public string licensestatus { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
