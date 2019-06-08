using GTA;

namespace TokkiTools.Extensions
{
    /// <summary>
    /// Extension for the game ped.
    /// </summary>
    public static class PedExtensions
    {
        /// <summary>
        /// If the ped is friendly with the player.
        /// </summary>
        /// <returns>true if the ped and player are companions, respect or like each other, false otherwise. </returns>
        public static bool IsFriendly(this Ped GamePed)
        {
            return Game.Player.Character.GetRelationshipWithPed(GamePed) <= Relationship.Like && GamePed.GetRelationshipWithPed(Game.Player.Character) <= Relationship.Like;
        }
    }
}
