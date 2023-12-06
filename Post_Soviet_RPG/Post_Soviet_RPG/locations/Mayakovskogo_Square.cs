namespace Post_Soviet_RPG.locations;

public class Mayakovskogo_Square : Location
{
    public override string Name { get; set; } = "Площадь Маяковского";
    public override List<Location> NeighboringLocations { get; set; }
    public override bool IsMainCharacterHere { get; set; } = false;
}