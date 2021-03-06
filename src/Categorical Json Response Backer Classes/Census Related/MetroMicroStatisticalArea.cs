﻿using System;
using Newtonsoft.Json;

namespace cSharpGeocodio
{
    /// <summary>
    /// JSON backer class used when deserializing responses from Geocodio.  Used when dealing with Census info.
    /// </summary>
    public class MetroMicroStatisticalArea
    {
        [JsonConstructor]
        public MetroMicroStatisticalArea(string name, string area_code, string type)
        {
            Name = name;
            AreaCode = area_code;
            Type = type;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("area_code")]
        public string AreaCode { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
