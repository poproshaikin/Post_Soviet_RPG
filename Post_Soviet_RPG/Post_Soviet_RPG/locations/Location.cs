using System;

namespace Post_Soviet_RPG
{
    public abstract class Location
    {
        public abstract string Name { get; set; }
        public abstract List<Location> NeighboringLocations { get; set; }
        // public abstract List<NPC> Visitors
        public abstract bool IsMainCharacterHere { get; set; }


    }
}