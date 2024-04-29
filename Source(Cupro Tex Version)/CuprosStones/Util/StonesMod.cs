using System;
using System.Linq;
using System.Reflection;

using HarmonyLib;
using UnityEngine;
using Verse;

namespace KurasStones {

  public sealed class StonesMod : Mod {


		public StonesMod(ModContentPack content) : base(content) {
      new Harmony("KurasStonesOverride").PatchAll(Assembly.GetExecutingAssembly());
      GetSettings<Settings>();
		}


    public override string SettingsCategory() {
      return Static.LabelModName;
    }


    public override void DoSettingsWindowContents(Rect rect) {
			Listing_Standard list = new Listing_Standard() {
				ColumnWidth = rect.width
			};
			list.Begin(rect);
      list.Gap(10);
      {
        Rect fullRect = list.GetRect(Text.LineHeight);
        Rect leftRect = fullRect.LeftHalf().Rounded();
        Rect rightRect = fullRect.RightHalf().Rounded();

        GenUI.SetLabelAlign(TextAnchor.MiddleRight);
        Widgets.Label(leftRect, Static.LabelStoneTypesAvailable);
        GenUI.ResetLabelAlign();

        Widgets.IntRange(rightRect, 316192000, ref Settings.StoneTypesAvailable, 1, 8);
      }

      list.Gap(25);
      {
				Rect fullRect = list.GetRect(30f);
        Rect leftLabelRect = fullRect.LeftHalf().Rounded();
				Rect rightLabelRect = fullRect.RightHalf().Rounded();

        Text.Font = GameFont.Medium;
				Text.Anchor = TextAnchor.MiddleCenter;

        Widgets.Label(leftLabelRect, Static.LabelStoneTypesToSpawn);
				
				Text.Anchor = TextAnchor.UpperLeft;
				Text.Font = GameFont.Small;
			}

			list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                Rect rightLabelRect = fullRect.RightHalf().Rounded();
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkDarkAndesite, StoneDefOf.ChunkAnorthosite,
                    StoneDefOf.DarkAndesite.LabelCap, StoneDefOf.Anorthosite.LabelCap,
                    ref Settings.SpawnDarkAndesite, ref Settings.SpawnAnorthosite
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkBasalt, StoneDefOf.ChunkBlueschist,
                    StoneDefOf.Basalt.LabelCap, StoneDefOf.Blueschist.LabelCap,
                    ref Settings.SpawnBasalt, ref Settings.SpawnBlueschist
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkChalk, StoneDefOf.ChunkCharnockite,
                    StoneDefOf.Chalk.LabelCap, StoneDefOf.Charnockite.LabelCap,
                    ref Settings.SpawnChalk, ref Settings.SpawnCharnockite
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkCreoleMarble, StoneDefOf.ChunkDacite,
                    StoneDefOf.CreoleMarble.LabelCap, StoneDefOf.Dacite.LabelCap,
                    ref Settings.SpawnCreoleMarble, ref Settings.SpawnDacite
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkVibrantDunite, StoneDefOf.ChunkEmperadordark,
                    StoneDefOf.VibrantDunite.LabelCap, StoneDefOf.Emperadordark.LabelCap,
                    ref Settings.SpawnVibrantDunite, ref Settings.SpawnEmperadordark
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkEtowahMarble, StoneDefOf.ChunkGreenGabbro,
                    StoneDefOf.EtowahMarble.LabelCap, StoneDefOf.GreenGabbro.LabelCap,
                    ref Settings.SpawnEtowahMarble, ref Settings.SpawnGreenGabbro
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkGranite, StoneDefOf.ChunkGreenSchist,
                    StoneDefOf.Granite.LabelCap, StoneDefOf.GreenSchist.LabelCap,
                    ref Settings.SpawnGranite, ref Settings.SpawnGreenSchist
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkJaspillite, StoneDefOf.ChunkLepidolite,
                    StoneDefOf.Jaspillite.LabelCap, StoneDefOf.Lepidolite.LabelCap,
                    ref Settings.SpawnJaspillite, ref Settings.SpawnLepidolite
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkLignite, StoneDefOf.ChunkLimestone,
                    StoneDefOf.Lignite.LabelCap, StoneDefOf.Limestone.LabelCap,
                    ref Settings.SpawnLignite, ref Settings.SpawnLimestone
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkLherzolite, StoneDefOf.ChunkMarble,
                    StoneDefOf.Lherzolite.LabelCap, StoneDefOf.Marble.LabelCap,
                    ref Settings.SpawnLherzolite, ref Settings.SpawnMarble
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkMigmatite, StoneDefOf.ChunkMonzonite,
                    StoneDefOf.Migmatite.LabelCap, StoneDefOf.Monzonite.LabelCap,
                    ref Settings.SpawnMigmatite, ref Settings.SpawnMonzonite
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkObsidian, StoneDefOf.ChunkRhyolite,
                    StoneDefOf.Obsidian.LabelCap, StoneDefOf.Rhyolite.LabelCap,
                    ref Settings.SpawnObsidian, ref Settings.SpawnRhyolite
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkSandstone, StoneDefOf.ChunkScoria,
                    StoneDefOf.Sandstone.LabelCap, StoneDefOf.Scoria.LabelCap,
                    ref Settings.SpawnSandstone, ref Settings.SpawnScoria
                );
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.RightHalf(),
                    StoneDefOf.ChunkSerpentinite, StoneDefOf.ChunkSiltstone,
                    StoneDefOf.Serpentinite.LabelCap, StoneDefOf.Siltstone.LabelCap,
                    ref Settings.SpawnSerpentinite, ref Settings.SpawnSiltstone
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                DualCheckboxesWithIcons_ThingDef(
                    fullRect.LeftHalf(),
                    StoneDefOf.ChunkSlate, StoneDefOf.ChunkSovite,
                    StoneDefOf.Slate.LabelCap, StoneDefOf.Sovite.LabelCap,
                    ref Settings.SpawnSlate, ref Settings.SpawnSovite
                );
            }
            list.Gap(10);
            {
                Rect fullRect = list.GetRect(30f);
                Rect leftRect = fullRect.LeftHalf().LeftHalf().RightPartPixels(150).Rounded();
                Rect leftIconRect = fullRect.LeftHalf().LeftHalf().LeftHalf().LeftHalf().RightPartPixels(30).Rounded();

                Widgets.ThingIcon(leftIconRect, StoneDefOf.ChunkThometzekite);

                Widgets.CheckboxLabeled(leftRect, StoneDefOf.Thometzekite.LabelCap, ref Settings.SpawnThometzekite);
                Widgets.DrawHighlightIfMouseover(leftRect);
            }
            GenUI.ResetLabelAlign();
            list.End();
        }


        private static void DualCheckboxesWithIcons_ThingDef(Rect rect, ThingDef leftThingDef, ThingDef rightThingDef, string leftLabel, string rightLabel, ref bool leftBool, ref bool rightBool) {
			Rect leftRect = rect.LeftHalf().RightPartPixels(150).Rounded();
			Rect rightRect = rect.RightHalf().RightPartPixels(150).Rounded();
			Rect leftIconRect = rect.LeftHalf().LeftHalf().LeftHalf().RightPartPixels(30).Rounded();
			Rect rightIconRect = rect.RightHalf().LeftHalf().LeftHalf().RightPartPixels(30).Rounded();

			Widgets.ThingIcon(leftIconRect, leftThingDef);
			Widgets.ThingIcon(rightIconRect, rightThingDef);

			Widgets.CheckboxLabeled(leftRect, leftLabel, ref leftBool);
			Widgets.CheckboxLabeled(rightRect, rightLabel, ref rightBool);
			Widgets.DrawHighlightIfMouseover(leftRect);
			Widgets.DrawHighlightIfMouseover(rightRect);
		}


		private static void DualCheckboxesWithIcons_Texture2D(Rect rect, Texture2D leftIcon, Texture2D rightIcon, string leftLabel, string rightLabel, ref bool leftBool, ref bool rightBool) {
			Rect leftRect = rect.LeftHalf().RightPartPixels(150).Rounded();
			Rect rightRect = rect.RightHalf().RightPartPixels(150).Rounded();
			Rect leftIconRect = rect.LeftHalf().LeftHalf().LeftHalf().RightPartPixels(30).Rounded();
			Rect rightIconRect = rect.RightHalf().LeftHalf().LeftHalf().RightPartPixels(30).Rounded();

			GUI.DrawTexture(leftIconRect, leftIcon);
			GUI.DrawTexture(rightIconRect, rightIcon);

			Widgets.CheckboxLabeled(leftRect, leftLabel, ref leftBool);
			Widgets.CheckboxLabeled(rightRect, rightLabel, ref rightBool);
			Widgets.DrawHighlightIfMouseover(leftRect);
			Widgets.DrawHighlightIfMouseover(rightRect);
		}
	}
}
