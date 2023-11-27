﻿namespace NSWalksAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public string Description { get; set; }

        public double LengthInKm { get; set; }

        public string? WalkImageUrl { get; set; }

        public Guid DiffiultyId { get; set; }

        public Guid RegionId { get; set; }


        // nativation prop
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }

    }
}
