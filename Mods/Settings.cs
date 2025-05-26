using LunarMenu.Classes;
using LunarMenu.Menu;
using System.IO;
using UnityEngine;
using static LunarMenu.Menu.Main;
using static LunarMenu.Settings;
using static LunarMenu.Menu.Buttons;

namespace LunarMenu.Mods
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 1;
            pageNumber = 0;
        }

        public static void MenuSettings()
        {
            buttonsType = 2;
            pageNumber = 0;
        }

        public static void MovementSettings()
        {
            buttonsType = 3;
            pageNumber = 0;
        }

        public static void ProjectileSettings()
        {
            buttonsType = 4;
            pageNumber = 0;
        }

        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }

        public static void ChangeSpeedBoost()
        {
            if (Speed == 1.5f) // speed
            {
                Speed = 2f;
            }
            else if (Speed == 2f) // fast
            {
                Speed = 10f;
            }
            else if (Speed == 5f) // Broken Speed
            {
                Speed = 100f;
            }
            else if (Speed == 10f) // und speed
            {
                Speed = 1.5f;
            }
        }

        public static void ChangeLongArmLength()
        {
            if (ArmLen == 1.25f)
            {
                ArmLen = 1.5f;
            }
            else if (ArmLen == 1.5f)
            {
                ArmLen = 2f;
            }
            else if (ArmLen == 2f)
            {
                ArmLen = 10f;
            }
            else if (ArmLen == 10f)
            {
                ArmLen = 50f;
            }
            else if (ArmLen == 50f)
            {
                ArmLen = 1.25f;
            }
        }

        public static void Goback() // Why not... 5/3/2025
        {
            memoriesarenice = "Opliation Menu"; // back to the old days... 5/3/2025
            currentColorA = blue; // WHY IS THERE SO MANY COMMENTS? 5/10/2025
            currentColorB = pink; // Why did i make this? 5/4/2025
        } // I don't know, but I'll keep it because it is true. This is what the mod menu was a long time ago. 5/4/2025

        public static void ChangeFlySpeed()
        {
            if (flySpeed == 15f)
            {
                flySpeed = 25f;
            }
            else if (flySpeed == 25f)
            {
                flySpeed = 50f;
            }
            else if (flySpeed == 50f)
            {
                flySpeed = 1000f;
            }
            else if (flySpeed == 1000f)
            {
                flySpeed = 15f;
            }
        }

        public static void ChangePlatformType()
        {
            if (platformType == "normal")
            {
                platformType = "invis";
            }
            else if (platformType == "invis")
            {
                platformType = "normal";
            }
        }

        private static string Mods;
        public static void SavePreset()
        {
            Mods = string.Empty;
            string lunarMenuPath = Path.Combine(Application.persistentDataPath, "LunarMenu");

            if (!Directory.Exists(lunarMenuPath))
            {
                Directory.CreateDirectory(lunarMenuPath);
            }

            foreach (ButtonInfo[] buttonGroup in buttons)
            {
                foreach (ButtonInfo button in buttonGroup)
                {
                    if (button.enabled)
                    {
                        Mods += button.buttonText + ";";
                    }
                }
            }

            File.WriteAllText(Path.Combine(lunarMenuPath, "LunarMenuPreset"), Mods);
        }

        public static void ChangeFakeLagDelayTime()
        {
            if (fakeLagDelayTime == 250)
            {
                fakeLagDelayTime = 1000;
            }
            else if (fakeLagDelayTime == 1000)
            {
                fakeLagDelayTime = 2000;
            }
            else if (fakeLagDelayTime == 2000)
            {
                fakeLagDelayTime = 250;
            }
        }

        public static void EnableInvisSpectator()
        {
            InvisSpectator = true;
        }

        public static void DisableInvisSpectator()
        {
            InvisSpectator = false;
        }

        public static void EnablePcSpectator()
        {
            pcSpector = true;
        }

        public static void DisablePcSpectator()
        {
            pcSpector = false;
        }
    }
}
