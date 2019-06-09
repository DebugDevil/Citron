using GTA;
using GTA.Native;
using System;
using System.Drawing;

namespace TokkiTools
{
    /// <summary>
    /// Functions that handle drawing of information on the screen.
    /// </summary>
    public static class Screen
    {
        /// <summary>
        /// Checks if the specified portion of the screen has been clicked.
        /// </summary>
        /// <param name="position">The starting position.</param>
        /// <param name="area"></param>
        /// <returns></returns>
        public static bool IsClicked(Point position, Size area)
        {
            // Get the relative x and y positions of the mouse
            float MouseX = Function.Call<float>(Hash.GET_CONTROL_NORMAL, 0, (int)Control.CursorX);
            float MouseY = Function.Call<float>(Hash.GET_CONTROL_NORMAL, 0, (int)Control.CursorY);
            // Convert those relative numbers to literal and round them
            int LiteralX = (int)Math.Round(MouseX * UI.WIDTH);
            int LiteralY = (int)Math.Round(MouseY * UI.HEIGHT);

            // Check if the mouse is inside of the area and return the result
            return (MouseX >= position.X && LiteralX <= position.X + area.Width) &&
                   (MouseY > position.Y && LiteralY < position.Y + area.Height);
        }

        /// <summary>
        /// Checks if the specified cheat has been entered by the player.
        /// </summary>
        /// <param name="cheat">The cheat to check.</param>
        /// <returns>true if the cheat was entered, false otherwise.</returns>
        public static bool HasCheatBeenEntered(string cheat)
        {
            return Function.Call<bool>(Hash._0x557E43C447E700A8, Game.GenerateHash(cheat)); // _HAS_CHEAT_STRING_JUST_BEEN_ENTERED
        }

        /// <summary>
        /// Shows a help message on the top left corner during 5 seconds with a beep.
        /// </summary>
        /// <param name="message">The message to show.</param>
        public static void ShowHelp(string message)
        {
            ShowHelp(message, 5000, true);
        }

        /// <summary>
        /// Shows a help message on the top left corner during 5 seconds.
        /// </summary>
        /// <param name="message">The message to show.</param>
        /// <param name="sound">If the notification should make a little beep.</param>
        public static void ShowHelp(string message, bool sound)
        {
            ShowHelp(message, 5000, sound);
        }

        /// <summary>
        /// Shows a help message on the top left corner with a beep.
        /// </summary>
        /// <param name="message">The message to show.</param>
        /// <param name="duration">The duration of the message in ms.</param>
        public static void ShowHelp(string message, int duration)
        {
            ShowHelp(message, duration, true);
        }

        /// <summary>
        /// Shows a help message on the top left corner.
        /// </summary>
        /// <param name="message">The message to show.</param>
        /// <param name="duration">The duration of the message in ms.</param>
        /// <param name="sound">If the notification should make a little beep.</param>
        public static void ShowHelp(string message, int duration, bool sound)
        {
            Function.Call(Hash._SET_TEXT_COMPONENT_FORMAT, "STRING"); // BEGIN_TEXT_COMMAND_DISPLAY_HELP
            Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, message); // ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME
            Function.Call(Hash._DISPLAY_HELP_TEXT_FROM_STRING_LABEL, 0, false, sound, duration); // END_TEXT_COMMAND_DISPLAY_HELP
        }
    }
}
