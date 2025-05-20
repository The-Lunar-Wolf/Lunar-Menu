using LunarMenu.Classes;
using UnityEngine;
using static LunarMenu.Menu.Main;

namespace LunarMenu
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient{colors = GetBlendedSolidGradient(currentColorB, currentColorA)};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient{colors = GetSolidGradient(currentColorA) }, // Disabled
            new ExtGradient{colors = GetSolidGradient(currentColorB)} // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = Font.CreateDynamicFontFromOSFont("Lora", 12);

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
