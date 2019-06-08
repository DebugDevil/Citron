using GTA;
using GTA.Math;

namespace TokkiTools
{
    /// <summary>
    /// Another ways to get the main player data.
    /// </summary>
    public static class PlayerData
    {
        /// <summary>
        /// Gets the position of the player ped or (if is present) the player vehicle.
        /// </summary>
        public static Vector3 Position
        {
            get
            {
                return Game.Player.Character.CurrentVehicle != null ? Game.Player.Character.CurrentVehicle.Position : Game.Player.Character.Position;
            }
        }

        /// <summary>
        /// Gets the rotation of the player ped or (if is present) the player vehicle.
        /// </summary>
        public static Vector3 Rotation
        {
            get
            {
                return Game.Player.Character.CurrentVehicle != null ? Game.Player.Character.CurrentVehicle.Rotation : Game.Player.Character.Rotation;
            }
        }
    }
}
