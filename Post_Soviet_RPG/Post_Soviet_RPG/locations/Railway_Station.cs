namespace Post_Soviet_RPG.locations
{
    public class Railway_Station : Location
    {
        public override string Name { get; set; } = "Железнодорожный вокзал";
        public override List<Location> NeighboringLocations { get; set; }
        public override bool IsMainCharacterHere { get; set; } = false;

        
    }
}
