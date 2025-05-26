using LunarMenu.Classes;
using LunarMenu.Mods;
using static LunarMenu.Settings;
using static LunarMenu.Menu.Main;

namespace LunarMenu.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods [0]
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => ModPage.MovementMods(), isTogglable = false, toolTip = "Opens the movement mods page."},
                new ButtonInfo { buttonText = "Fun", method =() => ModPage.FunMods(), isTogglable = false, toolTip = "Opens the fun mods page."},
                new ButtonInfo { buttonText = "Safty", method =() => ModPage.SaftyMods(), isTogglable = false, toolTip = "Opens the safty mods page."},
                new ButtonInfo { buttonText = "Projectile", method =() => ModPage.ProjectileMods(), isTogglable = false, toolTip = "Opens the Projectile mods page."},
                new ButtonInfo { buttonText = "OverPowered", method =() => ModPage.OverPoweredMods(), isTogglable = false, toolTip = "Opens the overpowered mods page."},
                new ButtonInfo { buttonText = "Room", method =() => ModPage.RoomMods(), isTogglable = false, toolTip = "Opens the room mods page."},
            },

            new ButtonInfo[] { // Settings [1]
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement Settings", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile Settings", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings [2]
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                new ButtonInfo { buttonText = "Go back...", method =() => SettingsMods.Goback(), isTogglable = false, toolTip = "Makes the menu back to what it orginally was..."},
                new ButtonInfo { buttonText = "Save Preset", method =() => SettingsMods.SavePreset(), isTogglable = false, toolTip = "Saves all of the mods that are enabled right now so you do not have to enable them everytime you join the game."},
            },

            new ButtonInfo[] { // Movement Settings [3]
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Change Speed Boost", method =() => SettingsMods.ChangeSpeedBoost(), isTogglable = false, toolTip = "Your current speed is now " + Speed.ToString() + "."},
                new ButtonInfo { buttonText = "Change Long Arm Length", method =() => SettingsMods.ChangeLongArmLength(), isTogglable = false, toolTip = "Your current Length is now " + ArmLen.ToString() + "."},
                new ButtonInfo { buttonText = "Change Fly Speed", method =() => SettingsMods.ChangeFlySpeed(), isTogglable = false, toolTip = "Your current fly speed is now " + flySpeed.ToString() + "."},
                new ButtonInfo { buttonText = "Change Platform Type", method =() => SettingsMods.ChangePlatformType(), isTogglable = false, toolTip = "Changes the type of you're platforms. Ex. from normal to invis."},
                new ButtonInfo { buttonText = "Change Fake Lag Delay", method =() => SettingsMods.ChangeFakeLagDelayTime(), isTogglable = false, toolTip = "Changes the delay time of fake lag."},
                new ButtonInfo { buttonText = "Invis Spectator", method =() => SettingsMods.EnableInvisSpectator(), disableMethod =() => SettingsMods.DisableInvisSpectator(), isTogglable = true, toolTip = "Makes you invisble while you spectate a player."},
                new ButtonInfo { buttonText = "Pc Spectator", method =() => SettingsMods.EnablePcSpectator(), disableMethod =() => SettingsMods.DisablePcSpectator(), isTogglable = true, toolTip = "Makes your pc spectate the player you want."},
            },

            new ButtonInfo[] { // Projectile Settings [4]
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },

            new ButtonInfo[] // Movement [5]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.PlatForms(), isTogglable = true, toolTip = "Enables platforms that you can use to fly with."},
                new ButtonInfo { buttonText = "Long Arms", method =() => Movement.LongArms(), isTogglable = true, disableMethod =() => Mods.Movement.FixArms(),toolTip = "Gives you longer arms."},
                new ButtonInfo { buttonText = "Custom Long Arms", method =() => Movement.CustomLongArms(), isTogglable = true, disableMethod =() => Mods.Movement.FixArms(), toolTip = "Gives you long arms that you can customize with your grips."},
                new ButtonInfo { buttonText = "SpeedBoost", method =() => Movement.SpeedBoost(), isTogglable = true, disableMethod =() => Mods.Movement.FixSpeed(),toolTip = "Gives you a speed boost"},
                new ButtonInfo { buttonText = "Custom SpeedBoost", method =() => Movement.CustomSpeedBoost(), isTogglable = true, disableMethod =() => Mods.Movement.FixSpeed(), toolTip = "Gives you a speed boost that you can customize with your grips."},
                new ButtonInfo { buttonText = "Fly", method =() => Movement.Fly(), isTogglable = true, toolTip = "Makes you fly."},
                new ButtonInfo { buttonText = "Noclip", method =() => Movement.Noclip(), isTogglable = true, toolTip = "Makes you noclip through the ground."},
                new ButtonInfo { buttonText = "Noclip Fly", method =() => Movement.NoclipFly(), isTogglable = true, toolTip = "Makes you noclip through the ground while flying."},
                new ButtonInfo { buttonText = "Custom Fly", method =() => Movement.customFly(), isTogglable = true, toolTip = "Makes you fly but you can change the speed by holding or clicking your grips."},
                new ButtonInfo { buttonText = "Frozone", method =() => Movement.Frozone(), isTogglable = true, toolTip = "gives you slipply platforms."},
                new ButtonInfo { buttonText = "Ghost Monkey", method =() => Movement.GhostMonkey(), isTogglable = true, toolTip = "Makes your rig freeze when you click A or X."},
                new ButtonInfo { buttonText = "Invisible Monkey", method =() => Movement.InvisMonkey(), isTogglable = true, toolTip = "Makes you invisible when you click B or Y."},
                new ButtonInfo { buttonText = "tp Gun", method =() => Movement.TeleportGun(), isTogglable = true, toolTip = "Gives you a gun that can teleport you to any place you want to go."},
                new ButtonInfo { buttonText = "Anti-Tag Freeze", method =() => Movement.AntiTagFreeze(), isTogglable = true, toolTip = "Makes it of where you cannot freeze after someone tags you."},
                new ButtonInfo { buttonText = "Uncap Max Velocity", method =() => Movement.UncapMaxVelocity(), isTogglable = true, disableMethod =() => Movement.FixSpeed(), toolTip = "Makes it of where the harder you swing "},
                new ButtonInfo { buttonText = "Car Monkey", method =() => Movement.CarMonkey(), isTogglable = true, toolTip = "Makes it of where you become a car."},
                new ButtonInfo { buttonText = "Rig Gun", method =() => Movement.RigGun(), isTogglable = true, toolTip = "Allows you to teleport your rig."},
                new ButtonInfo { buttonText = "Ascend <color=gray>[</color><color=green>Primary</color><color=gray>]</color>", method =() => Movement.Ascend(), isTogglable = true, toolTip = "Allows you to fly your rig up."},
                new ButtonInfo { buttonText = "Fake Lag", method =() => Movement.FakeLag(), isTogglable = true, disableMethod =() => Movement.FixRig(), toolTip = "Freezes you're rig and unfreezes you're rig."},
                new ButtonInfo { buttonText = "Spectator Gun <color=gray>[</color><color=red>This has not been tested.</color><color=gray>]</color>", method =() => Movement.SpectatorGun(), isTogglable = true, toolTip = "Gives you a gun that makes you spectate the player that you want to spectate."},
            },

            new ButtonInfo[] // OverPowered [6]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."},
                new ButtonInfo { buttonText = "Tag Gun", method =() => OverPowered.TagGun(), isTogglable = true, toolTip = "Gives you a gun that can tag any player you want to tag."},
                new ButtonInfo { buttonText = "Tag All", method =() => OverPowered.TagAll(), isTogglable = false, toolTip = "Tags every player in the lobby."},
                new ButtonInfo { buttonText = "Freeze Gun", method =() => OverPowered.FreezeGun(), isTogglable = true, toolTip = "Gives you a gun that can freeze any player you want to freeze."},
                new ButtonInfo { buttonText = "Freeze All", method =() => OverPowered.FreezeAll(), isTogglable = false, toolTip = "Freezes every player in the lobby."},
                new ButtonInfo { buttonText = "Hide Player Gun", method =() => OverPowered.HidePlayerGun(), isTogglable = true, toolTip = "Makes a someone that you pick become invisble. (they can't go back)"},
            },

            new ButtonInfo[] // Fun [7]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."},
                new ButtonInfo { buttonText = "Grab Doug", method =() => Fun.GrabDoug(), isTogglable = true, toolTip = "Makes it of where you can grab doug from anywhere."},
                new ButtonInfo { buttonText = "Grab Mat", method =() => Fun.GrabMat(), isTogglable = true, toolTip = "Makes it of where you can grab mat from anywhere."},
                new ButtonInfo { buttonText = "Ride Doug", method =() => Fun.RideDoug(), isTogglable = true, toolTip = "Makes it of where you can ride doug from anywhere."},
                new ButtonInfo { buttonText = "Ride Mat", method =() => Fun.RideMat(), isTogglable = true, toolTip = "Makes it of where you can ride mat from anywhere."},
                new ButtonInfo { buttonText = "Doug Gun", method =() => Fun.DougGun(), isTogglable = true, toolTip = "Gives you a gun that will teleport doug to the pointer."},
                new ButtonInfo { buttonText = "Mat Gun", method =() => Fun.MatGun(), isTogglable = true, toolTip = "Gives you a gun that will teleport mat to the pointer."},
            },

            new ButtonInfo[] // Safty [8]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."},
                new ButtonInfo { buttonText = "No Finger Movement", method =() => Safty.NoFingerMovement(), isTogglable = true, toolTip = "Makes your fingers not move at all."},
                new ButtonInfo { buttonText = "Anti Report <color=gray>[</color><color=purple>Disconnect</color><color=gray>]</color>", method =() => Safty.AntiReportDisconnect(), isTogglable = true, toolTip = "Makes it of where you can't get reported."},
                new ButtonInfo { buttonText = "Anti Report <color=gray>[</color><color=purple>Join Random</color><color=gray>]</color>", method =() => Safty.AntiReportJoinRandom(), isTogglable = true, toolTip = "Makes it of where you can't get reported."},
                new ButtonInfo { buttonText = "Anti Report <color=gray>[</color><color=purple>Reconnect</color><color=gray>]</color>", method =() => Safty.AntiReportReconnect(), isTogglable = true, toolTip = "Makes it of where you can't get reported."},
                new ButtonInfo { buttonText = "Anti Report <color=gray>[</color><color=purple>Alert</color><color=gray>]</color>", method =() => Safty.AntiReportAlert(), isTogglable = true, toolTip = "Tells you when ever someone reports you."},
                new ButtonInfo { buttonText = "Anti Report <color=gray>[</color><color=purple>Anti Cheat</color><color=gray>]</color>", method =() => Safty.EnableAntiCheatReport(), isTogglable = true, toolTip = "Makes you not be able to not get reported by Gorilla Tag's anti cheat.", enabled = true, disableMethod =() => Safty.DisableAntiCheatReport()},
            },

            new ButtonInfo[] // Admin [9]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."},
                new ButtonInfo { buttonText = "Get Position of You", method =() => Admin.GetPositionOfPlayer(), isTogglable = false, toolTip = "Gets you the position of the player."},
                new ButtonInfo { buttonText = "Get Position of Your Right Hand", method =() => Admin.GetPositionOfPlayerHand(), isTogglable = false, toolTip = "Gets you the position of the player right hand."},
            },

            new ButtonInfo[] // Room [10]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."}, // What was i thinking on this day? 5/4/2025
                new ButtonInfo { buttonText = "Disconnect", method =() => Room.Disconnect(), isTogglable = false, toolTip = "Disconnects you from the lobby."}, // I have no idea 5/10/2025
                new ButtonInfo { buttonText = "Reconnect", method =() => Room.Reconnect(), isTogglable = false, toolTip = "Reconnects you to the lobby you where in."}, // When did i even make this? 5/19/25
                new ButtonInfo { buttonText = "Join Random", method =() => Room.JoinRandom(), isTogglable = false, toolTip = "Joins you into a random lobby."},
                new ButtonInfo { buttonText = "Quit", method =() => Room.QuitGame(), isTogglable = false, toolTip = "Quit the game for you."},
                new ButtonInfo { buttonText = "Clear Notifications on Disconnect", method =() => Room.EnableClearNotiOnDisconnect(), disableMethod =() => Room.DisableClearNotiOnDisconnect(), isTogglable = true, toolTip = "Clears your notifications when you disconnect from a lobby", enabled = true},
                new ButtonInfo { buttonText = "Check Master", method =() => Room.CheckMaster(), isTogglable = false, toolTip = "Checks if you are Master."},
                new ButtonInfo { buttonText = "Set Master", method =() => Room.SetMaster(), isTogglable = false, toolTip = "Sets you as the master client."},
                new ButtonInfo { buttonText = "Disconnect on Grip", method =() => Room.DisconnectOnGrip(), isTogglable = true, toolTip = "Disconnect from the lobby everytime you click your grip."},
                new ButtonInfo { buttonText = "Reconnect on Grip", method =() => Room.ReconnectOnGrip(), isTogglable = true, toolTip = "Reconnects you to the lobby you were in when you click your grip."},
                new ButtonInfo { buttonText = "Join Random on Grip", method =() => Room.JoinRandomOnGrip(), isTogglable = true, toolTip = "Joins a random lobby everytime you click grip."},
                new ButtonInfo { buttonText = "Quit on Grip", method =() => Room.QuitOnGrip(), isTogglable = true, toolTip = "Quits the game for you when you click grip."},
                new ButtonInfo { buttonText = "Disconnect on Trigger", method =() => Room.DisconnectOnTrigger(), isTogglable = true, toolTip = "Disconnect from the lobby everytime you click your trigger."},
                new ButtonInfo { buttonText = "Reconnect on Trigger", method =() => Room.ReconnectOnTrigger(), isTogglable = true, toolTip = "Reconnects you to the lobby you were in when you click your trigger."},
                new ButtonInfo { buttonText = "Join Random on Trigger", method =() => Room.JoinRandomOnTrigger(), isTogglable = true, toolTip = "Joins a random lobby everytime you click trigger."},
                new ButtonInfo { buttonText = "Quit on Trigger", method =() => Room.QuitGameOnTrigger(), isTogglable = true, toolTip = "Quits the game for you when you click trigger."},
            },

            new ButtonInfo[] // Projectile [11]
            {
                new ButtonInfo { buttonText = "Back", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns you to the main page of the menu."},
                new ButtonInfo { buttonText = "Urine", method =() => Projectile.Urine(), isTogglable = true, toolTip = "Allows you to pee. I don't know if it works. Please tell me if it does."},
            },
        };
    }
}