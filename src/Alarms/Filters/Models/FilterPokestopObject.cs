﻿namespace WhMgr.Alarms.Filters.Models
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// Pokemon filters
    /// </summary>
    public class FilterPokestopObject
    {
        /// <summary>
        /// Gets or sets a value determining whether to enable the pokestop filter
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether to only report lured Pokestops
        /// </summary>
        [JsonProperty("lured")]
        public bool Lured { get; set; }

        /// <summary>
        /// Gets or sets the Pokestop lure types to report
        /// </summary>
        [JsonProperty("lure_types")]
        public List<string> LureTypes { get; set; }

        /// <summary>
        /// Gets or sets a value determining whether to only report Team Rocket invasion Pokestops
        /// </summary>
        [JsonProperty("invasions")]
        public bool Invasions { get; set; }

        /// <summary>
        /// Instantiate a new <see cref="FilterPokestopObject"/> class
        /// </summary>
        public FilterPokestopObject()
        {
            LureTypes = new List<string>();
        }
    }
}