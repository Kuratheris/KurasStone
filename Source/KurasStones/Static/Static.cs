using UnityEngine;
using Verse;

namespace KurasStones {
	[StaticConstructorOnStartup]
  public static class Static {

    public static string LabelModName = "K_LabelModName".Translate();
    public static string LabelStoneTypesAvailable = "K_LabelStoneTypesAvailable".Translate();
		public static string LabelStoneTypesToSpawn = "K_StoneTypesToSpawn".Translate();

		public static Color WarningColor = new Color(1f, 0.4f, 0.4f);
	}
}
