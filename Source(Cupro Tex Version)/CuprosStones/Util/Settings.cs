using Verse;

namespace KurasStones {

  public class Settings : ModSettings {

    internal static IntRange StoneTypesAvailable = new IntRange(4, 5);

    internal static bool SpawnDarkAndesite = true;
    internal static bool SpawnAnorthosite = true;
    internal static bool SpawnBasalt = true;
    internal static bool SpawnBlueschist = true;
    internal static bool SpawnChalk = true;
    internal static bool SpawnCharnockite = true;
    internal static bool SpawnCreoleMarble = true;
    internal static bool SpawnDacite = true;
    internal static bool SpawnVibrantDunite = true;
    internal static bool SpawnEmperadordark = true;
    internal static bool SpawnEtowahMarble = true;
    internal static bool SpawnGreenGabbro = true;
    internal static bool SpawnGreenSchist = true;
    internal static bool SpawnJaspillite = true;
    internal static bool SpawnLepidolite = true;
    internal static bool SpawnLignite = true;
    internal static bool SpawnLherzolite = true;
    internal static bool SpawnMigmatite = true;
    internal static bool SpawnMonzonite = true;
    internal static bool SpawnObsidian = true;
    internal static bool SpawnRhyolite = true;
    internal static bool SpawnScoria = true;
    internal static bool SpawnSerpentinite = true;
    internal static bool SpawnSiltstone = true;
    internal static bool SpawnSovite = true;
    internal static bool SpawnThometzekite = true;
    internal static bool SpawnGranite = true;
    internal static bool SpawnLimestone = true;
    internal static bool SpawnMarble = true;
    internal static bool SpawnSandstone = true;
    internal static bool SpawnSlate = true;


        public override void ExposeData() {
      base.ExposeData();
      Scribe_Values.Look(ref StoneTypesAvailable, "StoneTypesAvailable", new IntRange(4, 5));
      Scribe_Values.Look(ref SpawnEmperadordark, "SpawnEmperadordark", true);
      Scribe_Values.Look(ref SpawnDarkAndesite, "SpawnDarkAndesite", true);
      Scribe_Values.Look(ref SpawnBlueschist, "SpawnBlueschist", true);
      Scribe_Values.Look(ref SpawnSerpentinite, "SpawnSerpentinite", true);
      Scribe_Values.Look(ref SpawnObsidian, "SpawnObsidian", true);
      Scribe_Values.Look(ref SpawnAnorthosite, "SpawnAnorthosite", true);
      Scribe_Values.Look(ref SpawnBasalt, "SpawnBasalt", true);
      Scribe_Values.Look(ref SpawnCharnockite, "SpawnCharnockite", true);
      Scribe_Values.Look(ref SpawnVibrantDunite, "SpawnVibrantDunite", true);
      Scribe_Values.Look(ref SpawnDacite, "SpawnDacite", true);
      Scribe_Values.Look(ref SpawnGreenGabbro, "SpawnGreenGabbro", true);
      Scribe_Values.Look(ref SpawnLherzolite, "SpawnLherzolite", true);
      Scribe_Values.Look(ref SpawnMonzonite, "SpawnMonzonite", true);
      Scribe_Values.Look(ref SpawnRhyolite, "SpawnRhyolite", true);
      Scribe_Values.Look(ref SpawnScoria, "SpawnScoria", true);
      Scribe_Values.Look(ref SpawnSovite, "SpawnSovite", true);
      Scribe_Values.Look(ref SpawnChalk, "SpawnChalk", true);
      Scribe_Values.Look(ref SpawnJaspillite, "SpawnJaspillite", true);
      Scribe_Values.Look(ref SpawnLignite, "SpawnLignite", true);
      Scribe_Values.Look(ref SpawnSiltstone, "SpawnSiltstone", true);
      Scribe_Values.Look(ref SpawnDacite, "SpawnDacite", true);
      Scribe_Values.Look(ref SpawnGreenSchist, "SpawnGreenSchist", true);
      Scribe_Values.Look(ref SpawnMigmatite, "SpawnMigmatite", true);
      Scribe_Values.Look(ref SpawnCreoleMarble, "SpawnCreoleMarble", true);
      Scribe_Values.Look(ref SpawnEtowahMarble, "SpawnEtowahMarble", true);
      Scribe_Values.Look(ref SpawnThometzekite, "SpawnThometzekite", true);
      Scribe_Values.Look(ref SpawnLepidolite, "SpawnLepidolite", true);
      Scribe_Values.Look(ref SpawnLimestone, "SpawnLimestone", true);
      Scribe_Values.Look(ref SpawnSandstone, "SpawnSandstone", true);
      Scribe_Values.Look(ref SpawnMarble, "SpawnMarble", true);
      Scribe_Values.Look(ref SpawnSlate, "SpawnSlate", true);
      Scribe_Values.Look(ref SpawnGranite, "SpawnGranite", true);
        }


    public static bool StoneAllowedOrUndefined(ThingDef stone) {
      if (stone == StoneDefOf.Emperadordark) {
        return SpawnEmperadordark;
      }
      if (stone == StoneDefOf.DarkAndesite) {
        return SpawnDarkAndesite;
      }
      if (stone == StoneDefOf.Blueschist) {
        return SpawnBlueschist;
      }
      if (stone == StoneDefOf.Serpentinite) {
        return SpawnSerpentinite;
      }
      if (stone == StoneDefOf.Obsidian) {
        return SpawnObsidian;
      }
      if (stone == StoneDefOf.Anorthosite) {
        return SpawnAnorthosite;
      }
      if (stone == StoneDefOf.Basalt) {
        return SpawnBasalt;
      }
      if (stone == StoneDefOf.GreenGabbro) {
        return SpawnGreenGabbro;
      }
      if (stone == StoneDefOf.Charnockite) {
        return SpawnCharnockite;
      }
      if (stone == StoneDefOf.VibrantDunite) {
        return SpawnVibrantDunite;
      }
      if (stone == StoneDefOf.Dacite) {
        return SpawnDacite;
      }
      if (stone == StoneDefOf.Lherzolite) {
        return SpawnLherzolite;
      }
      if (stone == StoneDefOf.Monzonite) {
        return SpawnMonzonite;
      }
      if (stone == StoneDefOf.Rhyolite) {
        return SpawnRhyolite;
      }
      if (stone == StoneDefOf.Scoria) {
        return SpawnScoria;
      }
      if (stone == StoneDefOf.Sovite) {
        return SpawnSovite;
      }
      if (stone == StoneDefOf.Chalk) {
        return SpawnChalk;
      }
      if (stone == StoneDefOf.Jaspillite) {
        return SpawnJaspillite;
      }
      if (stone == StoneDefOf.Lignite) {
        return SpawnLignite;
      }
      if (stone == StoneDefOf.Siltstone) {
        return SpawnSiltstone;
      }
      if (stone == StoneDefOf.GreenSchist) {
        return SpawnGreenSchist;
      }
      if (stone == StoneDefOf.Migmatite) {
        return SpawnMigmatite;
      }
      if (stone == StoneDefOf.CreoleMarble) {
        return SpawnCreoleMarble;
      }
      if (stone == StoneDefOf.EtowahMarble) {
        return SpawnEtowahMarble;
      }
      if (stone == StoneDefOf.Thometzekite) {
        return SpawnThometzekite;
      }
      if (stone == StoneDefOf.Lepidolite) {
        return SpawnLepidolite;
      }
      if (stone == StoneDefOf.Limestone) {
        return SpawnLimestone;
      }
      if (stone == StoneDefOf.Sandstone) {
        return SpawnSandstone;
      }
      if (stone == StoneDefOf.Marble) {
        return SpawnMarble;
      }
      if (stone == StoneDefOf.Slate) {
        return SpawnSlate;
      }
      if (stone == StoneDefOf.Granite) {
        return SpawnGranite;
      }
      return true;
    }
  }
}
