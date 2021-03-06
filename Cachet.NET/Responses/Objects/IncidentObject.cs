﻿namespace Cachet.NET.Responses.Objects
{
    using System;

    using global::Cachet.NET.Responses.Enums;

    using RestSharp.Deserializers;

    public class IncidentObject
    {
        [DeserializeAs(Name = "id")]
        public int Identifier
        {
            get;
            set;
        }

        [DeserializeAs(Name = "component_id")]
        public int ComponentId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public IncidentStatus Status
        {
            get;
            set;
        }
        public bool Visible
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public DateTime? ScheduledAt
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public DateTime UpdatedAt
        {
            get;
            set;
        }

        public DateTime? DeletedAt
        {
            get;
            set;
        }

        [DeserializeAs(Name = "human-status")]
        public string StatusName
        {
            get;
            set;
        }
        
    }
}
