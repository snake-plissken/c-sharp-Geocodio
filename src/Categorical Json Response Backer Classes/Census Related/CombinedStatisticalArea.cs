﻿using System;
using Newtonsoft.Json;

namespace cSharpGeocodio
{
    /// <summary>
    /// JSON backer class used when deserializing responses from Geocodio.  Used when dealing with Census info.
    /// </summary>
    public class CombinedStatisticalArea
    {
        [JsonConstructor]
        public CombinedStatisticalArea(string name, string area_code)
        {
            Name = name;
            AreaCode = area_code;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }
    }
}
