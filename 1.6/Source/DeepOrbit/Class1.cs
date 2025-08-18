using RimWorld.Planet;
using Verse;

namespace DeepOrbit
{
    public class BigAsteroidMapParent : SpaceMapParent
    {
        public override string GetInspectString()
        {
            string text = base.GetInspectString();
            if (preciousResource != null)
            {
                text += "\n" + "ManyOfPreciousResource".Translate(NamedArgumentUtility.Named(preciousResource, "RESOURCE"));
            }
            return text.Trim();
        }
    }

}
