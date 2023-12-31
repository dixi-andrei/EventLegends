﻿using EventLegends.Models.Base;

namespace EventLegends.Models
{
    public class Venue :BaseEntity
    {
        public string VenueName { get; set; }
        public string VenueAddress { get; set; }
        public int VenueCapacity { get; set; }

        //Relatie One-to-One
        public Event Event { get; set; }

        public Guid EventId { get; set; }
        /*
        public Venue() { }
        public Venue(int VenueId, string VenueName, string VenueAddress, int VenueCapacity, Event Event)
        {
            this.VenueId = VenueId;
            this.VenueName = VenueName;
            this.VenueAddress = VenueAddress;
            this.VenueCapacity = VenueCapacity;
            this.Event = Event;
        }
        */
    }
}
