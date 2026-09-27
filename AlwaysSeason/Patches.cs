using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;

namespace AlwaysSeason
{
    [HarmonyPatch(typeof(Player), "UpdateKnownRecipesList")]
    internal static class KnownRecipesPatch
    {
        private static void Prefix(Player __instance)
        {
            SeasonUnlock.Enable(__instance);
        }
    }

    [HarmonyPatch(typeof(Player), nameof(Player.GetAvailableRecipes))]
    internal static class AvailableRecipesPatch
    {
        private static void Prefix(Player __instance)
        {
            SeasonUnlock.Enable(__instance);
        }
    }

    [HarmonyPatch(typeof(PieceTable), nameof(PieceTable.UpdateAvailable))]
    internal static class PieceTablePatch
    {
        private static void Prefix(Player player)
        {
            SeasonUnlock.Enable(player);
        }
    }

    internal static class SeasonUnlock
    {
        private static bool _logged;

        internal static void Enable(Player player)
        {
            if (player == null)
            {
                return;
            }

            List<SeasonalItemGroup> groups = AccessTools.Field(typeof(Player), "m_seasonalItemGroups").GetValue(player) as List<SeasonalItemGroup>;
            if (groups == null)
            {
                return;
            }

            int recipes = 0;
            int pieces = 0;
            for (int i = 0; i < groups.Count; i++)
            {
                SeasonalItemGroup group = groups[i];
                if (group == null)
                {
                    continue;
                }

                if (group.Recipes != null)
                {
                    for (int r = 0; r < group.Recipes.Count; r++)
                    {
                        Recipe recipe = group.Recipes[r];
                        if (recipe != null && SeasonRules.ShouldBeCraftable(recipe.m_enabled, true) && !recipe.m_enabled)
                        {
                            recipe.m_enabled = true;
                            recipes++;
                        }
                    }
                }

                if (group.Pieces != null)
                {
                    for (int p = 0; p < group.Pieces.Count; p++)
                    {
                        GameObject pieceObject = group.Pieces[p];
                        Piece piece = pieceObject != null ? pieceObject.GetComponent<Piece>() : null;
                        if (piece != null && SeasonRules.ShouldBeCraftable(piece.m_enabled, true) && !piece.m_enabled)
                        {
                            piece.m_enabled = true;
                            pieces++;
                        }
                    }
                }
            }

            if (!_logged && (recipes > 0 || pieces > 0))
            {
                _logged = true;
                Plugin.LogInfo("Seasonal items unlocked all year. Recipes: " + recipes + ", pieces: " + pieces);
            }
        }
    }
}
