/*using LudeonTK;
using RimWorld.Planet;
using RimWorld;
using Verse;
using UnityEngine;
using System.Reflection.Emit;

namespace DeepOrbit
{
    internal class Debug_DeepOrbit
    {
        public static bool drawResourcesNetGrid = false;

        public static bool debugLogging = false;
        private static PlanetTile tile;

        public static GeneratedLocationDef BigAsteroids { get; private set; }
        public static WorldObjectDef BigAsteroidBasic { get; private set; }
        public static PlanetLayerDef Orbit2 { get; private set; }
        public static World world { get; private set; }

        [DebugAction("Deep Orbit", "Spawn a Big Asteroid", false, false, actionType = DebugActionType.Action, allowedGameStates = AllowedGameStates.PlayingOnWorld)]


        private static void GenerateLocationForLayer()
        {
            GeneratedLocationDef generatedLocationDef = BigAsteroids;
            WorldObjectDef worldObjectDef = BigAsteroidBasic;
            WorldObject worldObject = WorldObjectMaker.MakeWorldObject(generatedLocationDef.worldObjectDef);
            if (worldObject is INameableWorldObject nameableWorldObject)
            {
                nameableWorldObject.Name = NameGenerator.GenerateName(worldObject.def.nameMaker, null, appendNumberIfNameUsed: false, "r_name", null, null);
            }
            if (worldObject is IResourceWorldObject resourceWorldObject && !generatedLocationDef.preciousResources.NullOrEmpty())
            {
                resourceWorldObject.PreciousResource = generatedLocationDef.preciousResources.RandomElement();
            }
            if (worldObject is IExpirableWorldObject expirableWorldObject && !generatedLocationDef.TimeoutRangeDays.IsZeros)
            {
                expirableWorldObject.ExpireAtTicks = GenTicks.TicksGame + (int)(generatedLocationDef.TimeoutRangeDays.RandomInRange * 60000f);
            }
            worldObject.isGeneratedLocation = true;
            worldObject.Tile = TryFindSiteTile(Orbit2);
            Find.WorldObjects.Add(worldObject);
            
        }

        public static void Message(string msg)
        {
            if (debugLogging)
                Log.Message($"[DeepOrbit] {msg}");
        }

        public static bool TryFindSiteTile(PlanetLayer layer, out PlanetTile tile)
        {
            tile = PlanetTile.Invalid;
            PlanetTile other = new PlanetTile(0, Find.WorldGrid.Surface);
            if (TileFinder.TryFindRandomPlayerTile(out var tile2, allowCaravans: false))
            {
                other = tile2;
            }
            return TileFinder.TryFindTileWithDistance(layer.GetClosestTile(other), 0, int.MaxValue, out tile, Validator);
            bool Validator(PlanetTile x)
            {
                return !Find.WorldObjects.AnyWorldObjectAt(x);
            }
        }
    }
}
*/